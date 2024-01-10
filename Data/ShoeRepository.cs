using System;
using ShoeWebshop.Models;

namespace ShoeWebshop.Data
{
	public class ShoeRepository: IShoeRepository
	{
        private ApplicationDbContext _db;
        public ShoeRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        public IEnumerable<Shoe>? ReadAll()
        {
            return _db.Shoes.ToList();
        }
        public void Create(Shoe new_shoe)
        {
            _db.Shoes.Add(new_shoe);
            _db.SaveChanges();
        }
    }

    public interface IShoeRepository
    {
        IEnumerable<Shoe>? ReadAll();
        void Create(Shoe new_shoe);
    }
}

