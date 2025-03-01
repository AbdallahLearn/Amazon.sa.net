using System.ComponentModel.DataAnnotations;

namespace AmazonSA.Models
{
    public class User
    {
        [Key]
        public int UserID { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
