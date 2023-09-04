using System;
using Microsoft.AspNetCore.Identity;

namespace ShoeWebshop.Models
{
	public class SiteUser : IdentityUser
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Address { get; set; }
	}
}

