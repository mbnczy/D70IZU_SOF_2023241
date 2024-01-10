using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace ShoeWebshop.Models
{
	public class SiteUser : IdentityUser
	{

		[Required]
		public string FirstName { get; set; }

		[Required]
		public string LastName { get; set; }
		public string Address { get; set; }
		public DateTime Created_at { get; set; }
        public DateTime Updated_at { get; set; }

    }
}

