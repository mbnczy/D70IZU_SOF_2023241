using System;
using ShoeWebshop.Models;

namespace ShoeWebshop.Data
{
	public class CategoryRepository : ICategoryRepository
    {
		private ApplicationDbContext _db;
		public CategoryRepository(ApplicationDbContext db)
		{
			this._db = db;
		}
		public IEnumerable<Category>? ReadAll()
		{
			return _db.Categories.ToList();
		}

	}

    public interface ICategoryRepository
    {
		IEnumerable<Category>? ReadAll();
    }
}

