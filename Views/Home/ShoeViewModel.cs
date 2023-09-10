using System;
using ShoeWebshop.Models;

namespace ShoeWebshop.Views.Home
{
	public class ShoeViewModel
	{
		public Shoe Shoe { get; set; }
		public List<Color> Colors { get; set; }
	}
}

