using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Models
{
    public class Clothes
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; } 
        public string Brand { get; set; }
        [Required]
        public string Quantity { get; set; }
        public string Category { get; set; }
        [Required]
        public decimal Price { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
    }
}
