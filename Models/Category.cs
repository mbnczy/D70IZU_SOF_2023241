using System;
using System.ComponentModel.DataAnnotations;

namespace ShoeWebshop.Models
{
	public class Category
	{
        [Key]
		public string CategoryID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }

		//public Category()
		//{
		//	CategoryID = Guid.NewGuid().ToString();
		//}
	}
}

