using Microsoft.EntityFrameworkCore;

namespace InvoiceManagementPortal.Models
{
    public class InvoiceDbContext: DbContext
    {
        public InvoiceDbContext(DbContextOptions<InvoiceDbContext> options): base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<ServiceCategory> Services { get; set; }
        public DbSet<SubCategory> SubCategories { get; set; }
        public DbSet<ServicePlans> ServicePlans { get; set; }
    }
}
