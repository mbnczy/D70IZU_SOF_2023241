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
    }

    public interface IShoeRepository
    {
        IEnumerable<Shoe>? ReadAll();
    }
}

