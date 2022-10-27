using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InvoiceManagementPortal.Models
{
    public class ServicePlans
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("Title")]
        public SubCategory SubCat { get; set; }
        [ForeignKey("Plan")]
        public PlansType Type { get; set; }
        public int CompletionTime { get; set; } = 0;
        public int Revisions { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
