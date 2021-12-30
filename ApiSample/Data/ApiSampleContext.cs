using ApiSample.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSample.Data
{
    public class ApiSampleContext : DbContext
    {
        public ApiSampleContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Addresses> Addresses { get; set; } = null!;
        public DbSet<Brands> Brands { get; set; } = null!;
        public DbSet<Clients> Clients { get; set; } = null!;
        public DbSet<Groups> Groups { get; set; } = null!;
        public DbSet<Invoices> Invoices { get; set; } = null!;
        public DbSet<Orders> Orders { get; set; } = null!;
        public DbSet<PaymentClients> PaymentClients { get; set; } = null!;
        public DbSet<PaymentProviders> PaymentProviders { get; set; } = null!;
        public DbSet<Prices> Prices { get; set; } = null!;
        public DbSet<Products> Products { get; set; } = null!;
        public DbSet<ProductPrices> ProductPrices { get; set; } = null!;
        public DbSet<Providers> Providers { get; set; } = null!;
        public DbSet<Users> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Addresses>().ToTable("Addresses");
            modelBuilder.Entity<Brands>().ToTable("Brands");
            modelBuilder.Entity<Clients>().ToTable("Clients");
            modelBuilder.Entity<Groups>().ToTable("Groups");
            modelBuilder.Entity<Invoices>().ToTable("Invoices");
            modelBuilder.Entity<Orders>().ToTable("Orders");
            modelBuilder.Entity<PaymentClients>().ToTable("PaymentClients");
            modelBuilder.Entity<PaymentProviders>().ToTable("PaymentProviders");
            modelBuilder.Entity<Prices>().ToTable("Prices");
            modelBuilder.Entity<Products>().ToTable("Products");
            modelBuilder.Entity<ProductPrices>().ToTable("ProductPrices");
            modelBuilder.Entity<Providers>().ToTable("Providers");
            modelBuilder.Entity<Users>().ToTable("Users");
        }
    }
}
