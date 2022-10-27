using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceManagementPortal.Models
{
    public class SubCategory
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("Title")]
        public ServiceCategory Category { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
