using System.ComponentModel.DataAnnotations;

namespace EcommerceApp.Models
{
    public class Electronics
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string Unit { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        [Required]
        public decimal Price { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;

    }
}
