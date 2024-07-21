using Microsoft.EntityFrameworkCore;

namespace DesingPatterns.ChainOfResponsibility.DAL
{
    public class Context: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BATUR-EV;Database=DesingPattern1;Encrypt=false;Trusted_Connection=True;");
        }

        public DbSet<CustomerProcess> CustomerProcesses { get; set; }
    }
}
