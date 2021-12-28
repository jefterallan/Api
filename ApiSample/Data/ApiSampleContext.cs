using ApiSample.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiSample.Data
{
    public class ApiSampleContext : DbContext
    {
        public ApiSampleContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Brand> Brands { get; set; } = null!;
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Group> Groups { get; set; } = null!;
        public DbSet<Invoice> Invoices { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<PaymentClient> PaymentClients { get; set; } = null!;
        public DbSet<PaymentProvider> PaymentProviders { get; set; } = null!;
        public DbSet<Price> Prices { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductPrice> ProductPrices { get; set; } = null!;
        public DbSet<Provider> Providers { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().ToTable("Addresses");
            modelBuilder.Entity<Brand>().ToTable("Brands");
            modelBuilder.Entity<Client>().ToTable("Clients");
            modelBuilder.Entity<Group>().ToTable("Groups");
            modelBuilder.Entity<Invoice>().ToTable("Invoices");
            modelBuilder.Entity<Order>().ToTable("Orders");
            modelBuilder.Entity<PaymentClient>().ToTable("PaymentClients");
            modelBuilder.Entity<PaymentProvider>().ToTable("PaymentProviders");
            modelBuilder.Entity<Price>().ToTable("Prices");
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<ProductPrice>().ToTable("ProductPrices");
            modelBuilder.Entity<Provider>().ToTable("Providers");
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}
