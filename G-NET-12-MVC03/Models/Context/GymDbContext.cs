using G_NET_12_MVC03.FluentConfigurations;
using Microsoft.EntityFrameworkCore;

namespace G_NET_12_MVC03.Models.Context
{
    public class GymDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = GymG01Db ; Trusted_Connection = true ; TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Plan>(new PlanConfiguration());
        }
        public DbSet<Plan> Plans { get; set; }
    }
}
