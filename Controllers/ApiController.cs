using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ShoeWebshop.Data;
using ShoeWebshop.Models;

namespace ShoeWebshop.Controllers
{

    [ApiController]

    [Route("api/users")]
    public class ApiController:ControllerBase
    {
        UserManager<SiteUser> _userManager;

        public static List<string> Admins = new List<string>();
        public ApiController(UserManager<SiteUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IEnumerable<SiteUser>? GetUser()
        {
            var adminUsers = _userManager.Users
                .Where(user => Admins.Contains(user.Email))
                .ToList();


            

            return adminUsers;
        }
    }
}
