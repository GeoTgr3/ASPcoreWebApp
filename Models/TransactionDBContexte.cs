using Microsoft.EntityFrameworkCore;

namespace ASPcoreWebApp.Models
{
    public class TransactionDbContext : DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        { }

        public DbSet<Transactions> Transactions { get; set; }
    }
}
