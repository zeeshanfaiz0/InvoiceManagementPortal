using Microsoft.EntityFrameworkCore;

namespace InvoiceManagementPortal.Models
{
    public class InvoiceDbContext: DbContext
    {
        public InvoiceDbContext(DbContextOptions<InvoiceDbContext> options): base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
}
