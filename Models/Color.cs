using System;
using System.ComponentModel.DataAnnotations;

namespace ShoeWebshop.Models
{
	public class Color
	{
		[Key]
		public string ColorID { get; set; }
		public string Name { get; set; }
		public string Hexa_color { get; set; }

		//public Color()
		//{
		//	ColorID = Guid.NewGuid().ToString();
		//}
    }
}

