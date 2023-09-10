
using System;
using System.Diagnostics;
using System.Dynamic;
using System.Reflection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoeWebshop.Data;
using ShoeWebshop.Models;
using ShoeWebshop.Views.Home;

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
    public IActionResult ProductManagement(ShoeViewModel svm,
        IFormFile picturedata1,
        IFormFile picturedata2,
        IFormFile picturedata3,
        IFormFile picturedata4)
    {
        svm.Shoe.ShoeID = Guid.NewGuid().ToString();
        svm.Color.ShoeID = svm.Shoe.ShoeID;


        List<IFormFile> pictureDataList = new List<IFormFile>() { picturedata1, picturedata2, picturedata3, picturedata4 };
        PropertyInfo[] colorPropertyInfo = new PropertyInfo[5];
        PropertyInfo[] contentTypePropertyInfo = new PropertyInfo[5];
        for (int i = 1; i <= 4; i++)
        {
            colorPropertyInfo[i] = svm.Color.GetType().GetProperty("Image"+i);
            contentTypePropertyInfo[i] = svm.Color.GetType().GetProperty("ContentType"+i);
        }
        for (int i = 0; i < pictureDataList.Count; i++)
        {
            if (pictureDataList[i] is not null)
            {
                using (var stream = pictureDataList[i].OpenReadStream())
                {
                    byte[] buffer = new byte[pictureDataList[i].Length];
                    stream.Read(buffer, 0, (int)pictureDataList[i].Length);

                    // Set Image and ContentType properties using reflection
                    colorPropertyInfo[i + 1].SetValue(svm.Color, buffer);
                    contentTypePropertyInfo[i + 1].SetValue(svm.Color, pictureDataList[i].ContentType);
                }
            }
            else
            {
                colorPropertyInfo[i + 1].SetValue(svm.Color, new byte[0]);
                contentTypePropertyInfo[i + 1].SetValue(svm.Color, "");
            }
        }
        //using (var stream = picturedata1.OpenReadStream())
        //{
        //    byte[] buffer = new byte[picturedata1.Length];
        //    stream.Read(buffer, 0, (int)picturedata1.Length);
        //    svm.Color.Image1 = buffer;
        //    svm.Color.ContentType1 = picturedata1.ContentType;
        //}
        //svm.Color.Image2 = svm.Color.Image1;
        //svm.Color.Image3 = svm.Color.Image1;
        //svm.Color.Image4 = svm.Color.Image1;
        //svm.Color.ContentType2 = svm.Color.ContentType1;
        //svm.Color.ContentType3 = svm.Color.ContentType1;
        //svm.Color.ContentType4 = svm.Color.ContentType1;
        _db.Shoes.Add(svm.Shoe);
        _db.Colors.Add(svm.Color);
        _db.SaveChanges();
        return RedirectToAction(nameof(ProductManagement));
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

