using CarServiceManagementSystem.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarServiceManagementSystem.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        public DbSet<Car> Cars { get; set; }

        public DbSet<CarOption> CarOptions { get; set; }

        public DbSet<CarWarehouse> CarWarehouses { get; set; }

        public DbSet<Engine> Engines { get; set; }

        public DbSet<Oil> Oils { get; set; }

        public DbSet<Option> Options { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Part> Parts { get; set; }

        public DbSet<PartCategory> PartCategories { get; set; }

        public DbSet<PartsWarehouse> PartsWarehouses { get; set; }

        public DbSet<Repair> Repairs { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<CarOption>().HasKey(x => new { x.CarId, x.OptionId });

            builder.Entity<Repair>()
                .HasOne(x => x.Car)
                .WithMany(x => x.Repairs)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Order>()
                .HasOne(x => x.Mechanic)
                .WithMany(x => x.WorkOrders)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.Entity<Order>()
                .HasOne(x => x.User)
                .WithMany(x => x.ClientOrders)
                .OnDelete(DeleteBehavior.ClientSetNull);

            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}