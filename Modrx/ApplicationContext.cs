using Microsoft.EntityFrameworkCore;
using Modrx.Models;

namespace Modrx
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }

        public DbSet<SubaruDealer> SubaruDealers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SubaruDealer>()
                .HasIndex(d => d.SearchVector)
                .HasMethod("GIN");
        }
    }
}