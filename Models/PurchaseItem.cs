using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoeWebshop.Models
{
	public class PurchaseItem
	{
		[Key]
		public string PurchaseItemID { get; set; }
		public string PurchaseID { get; set; }
		public string Specific_shoe_detailsID { get; set; }
		public byte Quantity_purchased { get; set; }
		public int Sub_total { get; set; }

		[NotMapped]
		public virtual Purchase Purchase { get; set; }
        [NotMapped]
        public virtual SpecificShoe Specific_shoe_details { get; set; }

        public PurchaseItem()
		{
			PurchaseItemID = Guid.NewGuid().ToString();
		}
	}
}

