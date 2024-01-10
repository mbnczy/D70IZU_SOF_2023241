using System;
using System.ComponentModel.DataAnnotations;

namespace ShoeWebshop.Models
{
	public class Size
	{
		[Key]
		public string SizeID { get; set; }
		public string Value { get; set; }
		public string Details { get; set; }

		public Size()
		{
			SizeID = Guid.NewGuid().ToString();
		}
	}
}

