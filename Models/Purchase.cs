using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoeWebshop.Models
{
	public class Purchase
	{
		[Key]
		public string PurchaseID { get; set; }
		public string CustomerID { get; set; }
		public DateTime Purchase_date { get; set; }
		public string Total_amount { get; set; }

		[NotMapped]
		public virtual SiteUser Customer { get; set; }

		public Purchase()
		{
			PurchaseID = Guid.NewGuid().ToString();
		}

		
	}
}

