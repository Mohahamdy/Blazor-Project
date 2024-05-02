using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace Company.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string? ImgSrc { get; set; }

        [MinLength(3, ErrorMessage = "Name should be more than 3 chars")]
        public string Name { get; set; }

        [Range(10,100,ErrorMessage ="Price Should be Between $10 and $100")]
        public int Price { get; set; }


        [Range(0,4,ErrorMessage ="Choose Category, Please")]
        public int CategoryId{ get; set; }


       [Range(0,50)]
        public int Quantity { get; set; }
    }
}
