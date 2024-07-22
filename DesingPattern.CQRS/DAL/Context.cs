using Microsoft.EntityFrameworkCore;

namespace DesingPattern.CQRS.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BATUR-EV;Database=DesingPattern2;Encrypt=false;Trusted_Connection=True;");
        }

        public DbSet<Product> Products { get; set; }
    }
}
