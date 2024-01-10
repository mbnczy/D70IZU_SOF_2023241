using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ShoeWebshop.Models
{
    public class Color
    {
        [Key]
        public string ColorID { get; set; }

        public string ShoeID { get; set; }

        public string Name { get; set; }
        public string Hexa_code { get; set; }

        public byte[] Image1 { get; set; }
        public string ContentType1 { get; set; }
        public byte[] Image2 { get; set; }
        public string ContentType2 { get; set; }
        public byte[] Image3 { get; set; }
        public string ContentType3 { get; set; }
        public byte[] Image4 { get; set; }
        public string ContentType4 { get; set; }

        [NotMapped]
        public List<IFormFile> PictureData { get; set; }
        [NotMapped]
        public virtual Shoe Shoe { get; set; }

        public Color()
		{
			ColorID = Guid.NewGuid().ToString();
		}
	}
}

