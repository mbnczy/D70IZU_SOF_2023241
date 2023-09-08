using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoeWebshop.Data;
using ShoeWebshop.Models;

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
    public IActionResult ProductManagement()
    {
        return View(_userManager.Users);
    }
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

