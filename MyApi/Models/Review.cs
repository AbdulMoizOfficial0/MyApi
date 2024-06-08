using System.ComponentModel.DataAnnotations;

namespace MyApi.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }

        [Required]
        [Range(1, 5)]
        public int Rating { get; set; }

        [StringLength(1000)]
        public string Comment { get; set; }

        [Required]
        public DateTime ReviewDate { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int UserId { get; set; }

        // Navigation properties
        public Product Product { get; set; }
        public User User { get; set; }
    }
}
