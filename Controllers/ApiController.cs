using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ShoeWebshop.Models;

namespace ShoeWebshop.Controllers
{

    [ApiController]

    [Route("[controller]")]
    public class ApiController:ControllerBase
    {
        UserManager<SiteUser> _userManager;

        public ApiController(UserManager<SiteUser> userManager)
        {
            this._userManager = userManager;
        }


        [HttpGet]
        public IEnumerable<SiteUser> GetUsers()
        {
            return this._userManager.Users;
        }
    }
}
