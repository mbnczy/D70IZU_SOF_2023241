using System;
using ShoeWebshop.Models;

namespace ShoeWebshop.Data
{
	public class SizeRepository: ISizeRepository
    {
        private ApplicationDbContext _db;
        public SizeRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        public IEnumerable<Size>? ReadAll()
        {
            return _db.Sizes.ToList();
        }
        public void Create(Size newsshoe)
        {
            _db.Sizes.Add(newsshoe);
            _db.SaveChanges();
        }
    }

    public interface ISizeRepository
    {
        IEnumerable<Size>? ReadAll();
        void Create(Size newsshoe);

    }
}

