
using System;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
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
        dmodel.Brands = _db.Brands;
        dmodel.Categories = _db.Categories;
        dmodel.Colors = _db.Colors;
        return View(dmodel);
    }
    [HttpPost]
    public IActionResult ProductManagement(ShoeViewModel svm)
    {
        return View();
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
        return View();
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
    

}

