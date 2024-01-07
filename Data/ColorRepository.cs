using System;
using ShoeWebshop.Models;

namespace ShoeWebshop.Data
{
	public class ColorRepository : IColorRepository
    {

        private ApplicationDbContext _db;
        public ColorRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        public IEnumerable<Color>? ReadAll()
        {
            return _db.Colors.ToList();
        }
    }

    public interface IColorRepository
    {
        IEnumerable<Color>? ReadAll();
    }
}

