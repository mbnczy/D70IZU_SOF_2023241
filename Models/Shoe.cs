using System;
using System.ComponentModel.DataAnnotations;

namespace ShoeWebshop.Models
{
	public class Shoe
	{
        [Key]
        public string ShoeID { get; set; }
        public string CategoryID { get; set; }
        public string BrandID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Description { get; set; }
        public int Weight { get; set; }
        public string Images { get; set; }

        public Shoe()
        {
            ShoeID = Guid.NewGuid().ToString();
        }
    }
}

