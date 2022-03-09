using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Practice.Core;
using Practice.Core.Models;

namespace Practice.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Category>? Categories { get; set; }
        public DbSet<Product>? Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // Bu işlemi Seeds altında yapmak daha temiz.

            // modelBuilder.Entity<ProductFeature>().HasData(new ProductFeature()
            // {
            //     Id = 1,
            //     Color = "Kırmızı",
            //     Height = 100,
            //     Width = 200,
            //     ProductId = 1

            // });

            base.OnModelCreating(modelBuilder);
        }
    }
}   