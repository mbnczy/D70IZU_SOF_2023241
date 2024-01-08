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
        public IEnumerable<Color>? ReadSpecColors(string id)
        {
            return _db.Colors.Where(c => c.ShoeID == id).ToList();
        }
        public Color? Read(string id)
        {
            return _db.Colors.FirstOrDefault(x => x.ColorID == id);
        }
    }

    public interface IColorRepository
    {
        IEnumerable<Color>? ReadAll();
        IEnumerable<Color>? ReadSpecColors(string id);
        Color? Read(string id);
    }
}

