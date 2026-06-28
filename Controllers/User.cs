using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace azure_db_web_api.Controllers
{
    public class User
    {
        [Key]
        [Column("user_id")]
        public int UserId { get; set; }

        [Required]
        [MaxLength(50)]
        [Column("username")]
        public string Username { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [MaxLength(100)]
        [Column("email")]
        public string Email { get; set; } = string.Empty;

        [MaxLength(20)]
        [Column("role")]
        public string Role { get; set; } = "User";

        [MaxLength(20)]
        [Column("status")]
        public string Status { get; set; } = "Pending";

        [Column("created_at")]
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    }
}


