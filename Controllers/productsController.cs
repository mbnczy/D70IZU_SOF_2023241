
using System;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoeWebshop.Data;
using ShoeWebshop.Models;
using ShoeWebshop.Views.Products;

namespace ShoeWebshop.Controllers;

public class ProductsController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly UserManager<SiteUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly ApplicationDbContext _db;
    private readonly IShoeRepository _shoerep;
    private readonly ISpecificShoeRepository _specificshoerep;
    private readonly IColorRepository _colorrep;
    private readonly ICategoryRepository _categoryrep;
    private readonly ISizeRepository _sizerep;
    private readonly IBrandRepository _brandrep;

    public ProductsController(
        ILogger<HomeController> logger,
        UserManager<SiteUser> userManager,
        RoleManager<IdentityRole> roleManager,
        IShoeRepository shoerepository,
        ISpecificShoeRepository specificshoerepository,
        IColorRepository colorrepository,
        ICategoryRepository categoryrepository,
        ISizeRepository sizerepository,
        IBrandRepository brandrepository)
    {
        _logger = logger;
        _userManager = userManager;
        _roleManager = roleManager;
        //_db = db;
        _shoerep = shoerepository;
        _specificshoerep = specificshoerepository;
        _colorrep = colorrepository;
        _categoryrep = categoryrepository;
        _sizerep = sizerepository;
        _brandrep = brandrepository;
    }
    [Authorize(Roles = "Admin,Staff")]
    [HttpGet]
    public IActionResult ProductManagement()
    {
        dynamic dmodel = new ExpandoObject();
        dmodel.Brands = _brandrep.ReadAll();
        dmodel.Categories = _categoryrep.ReadAll();
        dmodel.Colors = _colorrep.ReadAll();
        dmodel.Shoes = _shoerep.ReadAll();
        return View(dmodel);
    }
    //[HttpPost]
    //public IActionResult ProductManagement(SpecificShoe sshoe)
    //{
    //    sshoe.SpecificShoeID = Guid.NewGuid().ToString();
    //    _db.Specific_shoe_details.Add(sshoe);
    //    _db.SaveChanges();
    //    return RedirectToAction(nameof(ProductManagement));
    //}

    [Authorize(Roles = "Admin,Staff")]
    [HttpGet]
    public IActionResult addshoe()
    {
        dynamic dmodel = new ExpandoObject();
        dmodel.Brands = _brandrep.ReadAll();
        dmodel.Categories = _categoryrep.ReadAll();
        dmodel.Colors = _colorrep.ReadAll();
        dmodel.Shoes = _shoerep.ReadAll();
        return View(dmodel);
    }

    [HttpPost]
    public IActionResult addshoe(ShoeViewModel svm)
    {
        svm.Shoe.ShoeID = Guid.NewGuid().ToString();

        if (svm.Colors is not null)
        {
            foreach (var Color in svm.Colors)
            {
                if (Color.Name is not null)
                {
                    Color.ColorID = Guid.NewGuid().ToString();
                    Color.ShoeID = svm.Shoe.ShoeID;
                    for (int i = 0; i < 4; i++)
                    {
                        if (i < Color.PictureData.Count)
                        {
                            using (var stream = Color.PictureData[i].OpenReadStream())
                            {
                                byte[] buffer = new byte[Color.PictureData[i].Length];
                                stream.Read(buffer, 0, (int)Color.PictureData[i].Length);

                                // Set Image and ContentType properties using reflection
                                Color.GetType().GetProperty("Image" + (i + 1)).SetValue(Color, buffer);
                                Color.GetType().GetProperty("ContentType" + (i + 1)).SetValue(Color, Color.PictureData[i].ContentType);
                            }

                        }
                        else
                        {
                            Color.GetType().GetProperty("Image" + (i + 1)).SetValue(Color, new byte[0]);
                            Color.GetType().GetProperty("ContentType" + (i + 1)).SetValue(Color, "");
                        }
                    }
                    _colorrep.Create(Color);
                }
            }
        }
        _shoerep.Create(svm.Shoe);

        return RedirectToAction(nameof(addshoe));
    }

    [HttpGet]
    public IActionResult addbrand()
    {
        List<Brand> brands = _brandrep.ReadAll().ToList();
        return View(brands);
    }
    [HttpPost]
    public IActionResult addbrand(Brand brand, IFormFile logodata)
    {
        brand.BrandID = Guid.NewGuid().ToString();
        using (var stream = logodata.OpenReadStream())
        {
            byte[] buffer = new byte[logodata.Length];
            stream.Read(buffer, 0, (int)logodata.Length);
            brand.Logo = buffer;
            brand.ContentType = logodata.ContentType;
        }
        _brandrep.Create(brand);
        return RedirectToAction(nameof(addbrand));
    }
    [HttpGet]
    public IActionResult Removebrand(string name)
    {
        var brand = _brandrep.ReadByName(name);
        _brandrep.Delete(brand);


        return RedirectToAction(nameof(addbrand));
    }
    /*
    [HttpPost]
    public IActionResult PM_Color(Color color, IFormFile image)
    {
        color.ColorID = Guid.NewGuid().ToString();
        //using (var stream = image.OpenReadStream())
        //{
        //    byte[] buffer = new byte[image.Length];
        //    stream.Read(buffer, 0, (int)image.Length);
        //    //shoe.Images = buffer;
        //    //shoe.ContentType = image.ContentType;
        //}
        _db.Colors.Add(color);
        _db.SaveChanges();
        return RedirectToAction(nameof(ProductManagement));
    }
    */
    //public IActionResult GetLogo(string id)
    //{
    //    Brand brand = _db.Brands.FirstOrDefault(x => x.BrandID == id);
    //    return new FileContentResult(brand.Logo, brand.ContentType);
    //}
    //public IActionResult GetFirstImage(string id)
    //{
    //    Color colorobj = _db.Colors.FirstOrDefault(x => x.ColorID == id);
    //    return new FileContentResult(colorobj.Image1, colorobj.ContentType1);
    //}
    public IActionResult GetLogo(string id)
    {
        Brand brand = _brandrep.Read(id);
        return new FileContentResult(brand.Logo, brand.ContentType);
    }
    public IActionResult GetFirstImage(string id)
    {
        Color colorobj = _colorrep.Read(id);//_db.Colors.ToList().FirstOrDefault(x => x.ShoeID == id);
        ;//_colorrep.Read(id);
        return new FileContentResult(colorobj.Image1, colorobj.ContentType1);
    }
}

