using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Brand
    {
        [Key]
        public int BrandId { get; set; }

        [Required]
        [StringLength(50)]

        public string? BrandName { get; set; }
        [Required]
        [StringLength(50)]
        public string? BrandDescription { get; set;}

        [Required]
         public int BrandOrder{ get; set;}
        public ICollection<Product>? Products { get; set;}
    }
}
