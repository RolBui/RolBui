using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        [Required]
        [StringLength(50)]
        public string? CategoryName { get; set; }
        [Required]
        [StringLength(50)]
        public string? CategoryDescription { get; set; }

        [Required]
        public int ? CategoryOrder { get; set; }
        public ICollection<Product>? Products { get; set; }

    }
}
