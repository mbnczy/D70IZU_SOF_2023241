using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ShoeWebshop.Models
{
	public class Shoe
	{
        [Key]


        public string ShoeID { get; set; }

        public string? CategoryID { get; set; }
        public string? BrandID { get; set; }

        [Required]
        public string Name { get; set; }
        public string Sex { get; set; }

        [Required]
        public string Description { get; set; }

        [Range(1,900000000)]
        public int Weight { get; set; }

        [NotMapped]
        public virtual Category Category { get; set; }
        [NotMapped]
        public virtual Brand Brand { get; set; }


        public Shoe()
        {
            ShoeID = Guid.NewGuid().ToString();
        }
    }
}

