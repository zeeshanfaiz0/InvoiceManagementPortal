using System.ComponentModel.DataAnnotations;

namespace InvoiceManagementPortal.Models
{
    public class PlansType
    {
        [Key]
        public int Id { get; set; }
        public String Plan { get; set; }
    }
}
