
using System;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoeWebshop.Data;
using ShoeWebshop.Models;
//using ShoeWebshop.Views.Home;
using ShoeWebshop.Views.Products;

namespace ShoeWebshop.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly UserManager<SiteUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly ApplicationDbContext _db;

    public HomeController(ILogger<HomeController> logger, UserManager<SiteUser> userManager, RoleManager<IdentityRole> roleManager, ApplicationDbContext db)
    {
        _logger = logger;
        _userManager = userManager;
        _roleManager = roleManager;
        _db = db;
    }

    public async Task<IActionResult> DelegateAdmin()
    {
        var principal = this.User;
        var user = await _userManager.GetUserAsync(principal);
        var role = new IdentityRole()
        {
            Name = "Admin"
        };

        if (!await _roleManager.RoleExistsAsync("Admin"))
        {
            await _roleManager.CreateAsync(role);
        }
        await _userManager.AddToRoleAsync(user, "Admin");
        return RedirectToAction(nameof(Index));
    }
    public async Task<IActionResult> DelegateStaff()
    {
        var principal = this.User;
        var user = await _userManager.GetUserAsync(principal);
        var role = new IdentityRole()
        {
            Name = "Staff"
        };

        if (!await _roleManager.RoleExistsAsync("Staff"))
        {
            await _roleManager.CreateAsync(role);
        }
        await _userManager.AddToRoleAsync(user, "Staff");
        return RedirectToAction(nameof(Index));
    }

    [Authorize(Roles = "Admin")]
    public IActionResult UserManagement()
    {
        return View(_userManager.Users);
    }


    [Authorize(Roles = "Admin,Staff")]
    [HttpGet]
    public IActionResult ProductManagement()
    {
        dynamic dmodel = new ExpandoObject();
        dmodel.Shoes = _db.Shoes.ToList();
        dmodel.Colors = _db.Colors.ToList();
        dmodel.Categories = _db.Categories.ToList();
        ;
        //dmodel.Colors = _db.Colors;
        return View(dmodel);
    }
    [HttpPost]
    public IActionResult ProductManagement(SpecificShoe sshoe)
    {
        sshoe.SpecificShoeID = Guid.NewGuid().ToString();
        ;
        _db.Specific_shoe_details.Add(sshoe);
        _db.SaveChanges();
        return RedirectToAction(nameof(ProductManagement));
    }
    [HttpGet]
    public IActionResult GetSizes()
    {
        var sizes = _db.Sizes.ToList();
        var jsonsizes = Json(sizes);

        return jsonsizes;
    }
    //[Authorize(Roles = "Admin,Staff")]
    //[HttpGet]
    //public IActionResult PM_AddShoe()
    //{
    //    dynamic dmodel = new ExpandoObject();
    //    dmodel.Brands = _db.Brands;
    //    dmodel.Categories = _db.Categories;
    //    dmodel.Colors = _db.Colors;
    //    return View(dmodel);
    //}

    //[HttpPost]
    //public IActionResult PM_AddShoe(ShoeViewModel svm)
    //{
    //    svm.Shoe.ShoeID = Guid.NewGuid().ToString();

    //    if (svm.Colors is not null)
    //    {
    //        foreach (var Color in svm.Colors)
    //        {
    //            if (Color.Name is not null)
    //            {
    //                Color.ColorID = Guid.NewGuid().ToString();
    //                Color.ShoeID = svm.Shoe.ShoeID;
    //                for (int i = 0; i < 4; i++)
    //                {
    //                    if (i < Color.PictureData.Count)
    //                    {
    //                        using (var stream = Color.PictureData[i].OpenReadStream())
    //                        {
    //                            byte[] buffer = new byte[Color.PictureData[i].Length];
    //                            stream.Read(buffer, 0, (int)Color.PictureData[i].Length);

    //                            // Set Image and ContentType properties using reflection
    //                            Color.GetType().GetProperty("Image" + (i + 1)).SetValue(Color, buffer);
    //                            Color.GetType().GetProperty("ContentType" + (i + 1)).SetValue(Color, Color.PictureData[i].ContentType);
    //                        }

    //                    }
    //                    else
    //                    {
    //                        Color.GetType().GetProperty("Image" + (i + 1)).SetValue(Color, new byte[0]);
    //                        Color.GetType().GetProperty("ContentType" + (i + 1)).SetValue(Color, "");
    //                    }
    //                }
    //                _db.Colors.Add(Color);
    //            }
    //        }
    //    }
    //    _db.Shoes.Add(svm.Shoe);
    //    _db.SaveChanges();
    //    return RedirectToAction(nameof(PM_AddShoe));
    //}

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


    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> RemoveAdmin(string uid)
    {
        var user = _userManager.Users.FirstOrDefault(t => t.Id == uid);
        await _userManager.RemoveFromRoleAsync(user, "Admin");
        return RedirectToAction(nameof(UserManagement));
    }
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GrantAdmin(string uid)
    {
        var user = _userManager.Users.FirstOrDefault(t => t.Id == uid);
        await _userManager.AddToRoleAsync(user, "Admin");
        return RedirectToAction(nameof(UserManagement));
    }
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> RemoveStaff(string uid)
    {
        var user = _userManager.Users.FirstOrDefault(t => t.Id == uid);
        await _userManager.RemoveFromRoleAsync(user, "Staff");
        return RedirectToAction(nameof(UserManagement));
    }
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GrantStaff(string uid)
    {
        var user = _userManager.Users.FirstOrDefault(t => t.Id == uid);
        await _userManager.AddToRoleAsync(user, "Staff");
        return RedirectToAction(nameof(UserManagement));
    }

    public IActionResult Index()
    {
        var sshoes = _db.Specific_shoe_details.ToList();

        return View(sshoes);
    }
    public IActionResult Mens()
    {
        var sshoes = _db.Specific_shoe_details.ToList().Where(x=>(x.Shoe.Sex).ToString().Equals("Male"));

        return View(sshoes);
    }
    public IActionResult Womens()
    {
        var sshoes = _db.Specific_shoe_details.ToList().Where(x=>(x.Shoe.Sex).ToString().Equals("Female"));

        return View(sshoes);
    }
    public IActionResult Shoe(string id)
    {
        SpecificShoe sshoe = _db.Specific_shoe_details.FirstOrDefault(t => t.SpecificShoeID == id);
        return View(sshoe);   
    }
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    [HttpGet]
    public IActionResult GetColorsById(string id)
    {
        var colors = _db.Colors.Where(c => c.ShoeID == id).ToList();
        var jsoncolors = Json(colors);
        
        return jsoncolors;
    }
    public IActionResult GetImages(string id)
    {
        //Color colorx = _db.Colors.FirstOrDefault(x => x.ColorID == id);
        //var spec_color = from color in _db.Colors
        //             where color.ColorID == id
        //             select new List<FileContentResult>()
        //             {
        //                new FileContentResult(color.Image1,color.ContentType1),
        //                new FileContentResult(color.Image2,color.ContentType2),
        //                new FileContentResult(color.Image3,color.ContentType3),
        //                new FileContentResult(color.Image4,color.ContentType4),
        //             };
        ////List<FileContentResult> results = from color in spec_color
        //var a = Json(spec_color);
        //;
        //return new FileContentResult(colorx.Image1, colorx.ContentType1);
        // Retrieve the Color object from the database

        Color color = _db.Colors.FirstOrDefault(x => x.ColorID == id);
        if (color != null)
        {
            // Create a list to store the FileContentResult objects
            List<FileContentResult> fileContentResults = new List<FileContentResult>();

            // Add FileContentResult objects for each image

            if (color.ContentType1 is not "")
            {
                fileContentResults.Add(new FileContentResult(color.Image1, color.ContentType1));
            }
            if (color.ContentType2 is not "")
            {
                fileContentResults.Add(new FileContentResult(color.Image2, color.ContentType2));
            }
            if (color.ContentType3 is not "")
            {
                fileContentResults.Add(new FileContentResult(color.Image3, color.ContentType3));
            }
            if (color.ContentType4 is not "")
            {
                fileContentResults.Add(new FileContentResult(color.Image4, color.ContentType4));
            }
            // Return the list of FileContentResult objects
            return new JsonResult(fileContentResults);
        }
        // Handle the case where the Color object was not found
        return NotFound();
    }


    public IActionResult GetImage(string id, string index)
    {
        int i = Convert.ToInt32(index);
        Color color = _db.Colors.FirstOrDefault(x => x.ColorID == id);

        string? contenttype = (string)typeof(Color).GetProperty($"ContentType{i}").GetValue(color);
        if (contenttype != "")
        {
            byte[] img = (byte[])typeof(Color).GetProperty($"Image{i}").GetValue(color);
            return new FileContentResult(img, contenttype);
        }
        else
        {
            return NotFound();
        };
    }
    public IActionResult GetImageCount(string id)
    {
        Color color = _db.Colors.FirstOrDefault(x => x.ColorID == id);

        int count = 1;
        while (count < 5 && (string)typeof(Color).GetProperty($"ContentType{count}").GetValue(color)!="")
        {
            count++;
        }
        return new JsonResult(count);
    }
}

