using System;
using ShoeWebshop.Models;

namespace ShoeWebshop.Data
{
	public class SpecificShoeRepository: ISpecificShoeRepository
	{
        private ApplicationDbContext _db;
        public SpecificShoeRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        public IEnumerable<SpecificShoe>? ReadAll()
        {
            return _db.Specific_shoe_details.ToList();
        }
        public SpecificShoe? Read(string id)
        {
            return _db.Specific_shoe_details.FirstOrDefault(t => t.SpecificShoeID == id);
        }
        public IEnumerable<SpecificShoe>? ReadMens()
        {
            return _db.Specific_shoe_details.ToList().Where(x => (x.Shoe.Sex).ToString().Equals("Male"));
        }
        public IEnumerable<SpecificShoe>? ReadWomens()
        {
            return _db.Specific_shoe_details.ToList().Where(x => (x.Shoe.Sex).ToString().Equals("Female"));
        }
        public void Create(SpecificShoe newsshoe)
        {
            _db.Specific_shoe_details.Add(newsshoe);
            _db.SaveChanges();
        }

        public bool BuyShoe(string id)
        {
            SpecificShoe? sshoe = this.Read(id);

            if (sshoe?.Quantity_in_stock > 0)
            {
                sshoe.Quantity_in_stock -= 1;
                _db.SaveChanges();
                return true;
            }
            else
            {
                sshoe.Order_type = "Out of Stock";
                return false;
            }
        }
    }

    public interface ISpecificShoeRepository
    {
        IEnumerable<SpecificShoe>? ReadAll();
        IEnumerable<SpecificShoe>? ReadMens();
        IEnumerable<SpecificShoe>? ReadWomens();
        SpecificShoe? Read(string id);
        void Create(SpecificShoe newsshoe);
        bool BuyShoe(string id);
    }
}

