﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoeWebshop.Models
{
	public class SpecificShoe
	{
		[Key]
		public string SpecificShoeID { get; set; }
		public string ShoeID { get; set; }
		public string ColorID { get; set; }
		public string SizesID { get; set; }
		[NotMapped]
		private string order_type;

        public string Order_type 
		{
			get 
			{
				if (this.Quantity_in_stock==0)
				{
					order_type = "Out of stock";
				}
				return order_type;
			}
			set 
			{
				this.order_type = value;
			} 
		}
		public int Quantity_in_stock { get; set; }
		public int Price { get; set; }
		public byte Discount { get; set; }

		[NotMapped]
		public int discount_Price
		{
			get
			{
				return Convert.ToInt32(Math.Ceiling(Convert.ToDecimal((double)((double)(100 - Discount) / 100) * Price)));
			}
		}

		[NotMapped]
        public virtual Shoe Shoe { get; set; }
        [NotMapped]
        public virtual Color Color { get; set; }
        [NotMapped]
        public virtual Size Size { get; set; }


        public SpecificShoe()
		{
			SpecificShoeID = Guid.NewGuid().ToString();
		}
	}
}

