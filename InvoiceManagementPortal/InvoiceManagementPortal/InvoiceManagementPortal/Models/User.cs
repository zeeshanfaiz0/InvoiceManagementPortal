using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceManagementPortal.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(20)")]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string LastName { get; set; } = string.Empty;
        
        [Required]
        [Column(TypeName = "nvarchar(30)")]
        public string Email { get; set; } = string.Empty;
        
        [Required]
        [Column(TypeName = "nvarchar(200)")]
        public string Password { get; set; } = string.Empty;
        public UserType Type { get; set; }


    }
}
