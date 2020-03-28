using Microsoft.EntityFrameworkCore;
using Modrx.Models;

namespace Modrx
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }

        public DbSet<SubaruDealer> SubaruDealers { get; set; }
    }
}