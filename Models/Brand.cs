﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoeWebshop.Models
{
	public class Brand
	{
		[Key]
		public string BrandID { get; set; }
		public string Name { get; set; }
		public string Country_of_origin { get; set; }
		public DateTime Founded_year { get; set; }

		public byte[] Logo { get; set; }
		public string ContentType { get; set; }

		[NotMapped]
		public IFormFile PictureData { get; set; }


		public Brand()
		{
			BrandID = Guid.NewGuid().ToString();
		}
	}
}

