using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoeWebshop.Data;
using ShoeWebshop.Models;

namespace ShoeWebshop.Controllers
{

    [ApiController]

    [Route("api/users")]
    public class ApiController:ControllerBase
    {
        UserManager<SiteUser> _userManager;


        public ApiController(UserManager<SiteUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IEnumerable<SiteUser>? GetUser()
        {
            return this._userManager.Users;
        }
    }
}
