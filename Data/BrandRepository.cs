using System;
using ShoeWebshop.Models;

namespace ShoeWebshop.Data
{
	public class BrandRepository: IBrandRepository
    {
        private ApplicationDbContext _db;
        public BrandRepository(ApplicationDbContext db)
        {
            this._db = db;
        }
        public IEnumerable<Brand>? ReadAll()
        {
            return _db.Brands.ToList();
        }
        public void Create(Brand new_brand)
        {
            _db.Brands.Add(new_brand);
            _db.SaveChanges();
        }
        public void Delete(Brand new_brand)
        {
            _db.Brands.Remove(new_brand);
            _db.SaveChanges();
        }
        public Brand Read(string id)
        {
            return _db.Brands.FirstOrDefault(x => x.BrandID == id);
        }
        public Brand ReadByName(string name)
        {
            return _db.Brands.ToList().FirstOrDefault(x => x.Name == name);
        }
    }


    public interface IBrandRepository
    {
        IEnumerable<Brand>? ReadAll();
        void Create(Brand new_brand);
        void Delete(Brand new_brand);
        Brand Read(string id);
        Brand ReadByName(string name);
    }
}

