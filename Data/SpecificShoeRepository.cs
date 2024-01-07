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
        public void Create(SpecificShoe newsshoe)
        {
            _db.Specific_shoe_details.Add(newsshoe);
            _db.SaveChanges();
        }
    }

    public interface ISpecificShoeRepository
    {
        IEnumerable<SpecificShoe>? ReadAll();
        void Create(SpecificShoe newsshoe);

    }
}

