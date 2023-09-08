using System;
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
		public string Specific_images { get; set; }
		public string Order_type { get; set; }
		public int Quantity_in_stock { get; set; }
		public int Price { get; set; }
		public byte Discount { get; set; }

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

