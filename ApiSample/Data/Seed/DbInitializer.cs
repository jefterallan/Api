using ApiSample.Data.Models;
using ApiSample.Data.Models.Enum;

namespace ApiSample.Data.Seed
{
    public static class DbInitializer
    {
        public static void Initialize(ApiSampleContext context)
        {
            context.Database.EnsureCreated();

            if (context.Users.Any())
            {
                return;
            }

            var brands = new Brand[]
            {
                new Brand("test1"),
                new Brand("test2"),
                new Brand("test3"),
                new Brand("test4"),
                new Brand("test5")
            };

            context.Brands.AddRange(brands);
            context.SaveChanges();

            var groups = new Group[]
            {
                new Group("Admin"),
                new Group("Employe"),
                new Group("Vendor"),
                new Group("Provider"),
                new Group("Architect")
            };

            context.Groups.AddRange(groups);
            context.SaveChanges();

            var prices = new Price[]
            {
                new Price(5,10,DateTime.Today, DateTime.Today.AddDays(10)),
                new Price(6,11,DateTime.Today, DateTime.Today.AddDays(10)),
                new Price(7,12,DateTime.Today, DateTime.Today.AddDays(10)),
                new Price(8,13,DateTime.Today, DateTime.Today.AddDays(10)),
                new Price(9,14,DateTime.Today, DateTime.Today.AddDays(10))
            };

            context.Prices.AddRange(prices);
            context.SaveChanges();

            var brand = context.Brands.OrderBy(x => x.Id).ToList();

            var products = new Product[]
            {
                new Product("01", "test1", 10, brand.First()),
                new Product("02", "test2", 20, brand.Take(2).Last()),
                new Product("03", "test3", 30, brand.Take(3).Last()),
                new Product("04", "test4", 40, brand.Take(4).Last()),
                new Product("05", "test5", 50, brand.Last())
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var product = context.Products.OrderBy(x => x.Id).ToList();
            var price = context.Prices.OrderBy(x => x.Id).ToList();

            var productPrices = new ProductPrice[]
            {
                new ProductPrice(product.First(), price.First()),
                new ProductPrice(product.Take(2).Last(), price.Take(2).Last()),
                new ProductPrice(product.Take(3).Last(), price.Take(3).Last()),
                new ProductPrice(product.Take(4).Last(), price.Take(4).Last()),
                new ProductPrice(product.Last(), price.Last())
            };

            context.ProductPrices.AddRange(productPrices);
            context.SaveChanges();

            var group = context.Groups.OrderBy(x => x.Id).ToList();

            var users = new User[]
            {
                new User("Test1", group.First()),
                new User("Test2", group.Take(2).Last()),
                new User("Test3", group.Take(3).Last()),
                new User("Test4", group.Take(4).Last()),
                new User("Test5", group.Last())
            };

            context.Users.AddRange(users);
            context.SaveChanges();

            var addresses = new Address[]
            {
                new Address("test1", "1", "test1", "test1", 12345678, "test1"),
                new Address("test2", "2", "test2", "test2", 12345678, "test2"),
                new Address("test3", "3", "test3", "test3", 12345678, "test3"),
                new Address("test4", "4", "test4", "test4", 12345678, "test4"),
                new Address("test5", "5", "test5", "test5", 12345678, "test5")
            };

            context.Addresses.AddRange(addresses);
            context.SaveChanges();

            var clients = new Client[]
            {
                new Client("1", Gender.Male, DateTime.Now),
                new Client("2", Gender.Male, DateTime.Now),
                new Client("3", Gender.Female, DateTime.Now),
                new Client("4", Gender.Female, DateTime.Now),
                new Client("5", Gender.Other, DateTime.Now)
            };

            context.Clients.AddRange(clients);
            context.SaveChanges();

            var providers = new Provider[]
            {
                new Provider("test1", "1", DateTime.Now),
                new Provider("test2", "2", DateTime.Now),
                new Provider("test3", "3", DateTime.Now),
                new Provider("test4", "4", DateTime.Now),
                new Provider("test5", "5", DateTime.Now)
            };

            context.Providers.AddRange(providers);
            context.SaveChanges();

            var provider = context.Providers.OrderBy(x => x.Id).ToList();

            var invoices = new Invoice[]
            {
                new Invoice(1, 1, 0, 0, 1, 2, DateTime.Now, provider.First(), product.First()),
                new Invoice(2, 1, 0, 0, 2, 3, DateTime.Now, provider.Take(2).Last(), product.Take(2).Last()),
                new Invoice(3, 1, 0, 0, 3, 4, DateTime.Now, provider.Take(3).Last(), product.Take(3).Last()),
                new Invoice(4, 1, 0, 0, 4, 5, DateTime.Now, provider.Take(4).Last(), product.Take(4).Last()),
                new Invoice(5, 1, 0, 0, 5, 6, DateTime.Now, provider.Last(), product.Last())
            };

            context.Invoices.AddRange(invoices);
            context.SaveChanges();

            var client = context.Clients.OrderBy(x => x.Id).ToList();

            var orders = new Order[]
            {
                new Order(1, 1, 0, 1, 2, DateTime.Now, client.First(), product.First()),
                new Order(2, 1, 0, 2, 3, DateTime.Now, client.Take(2).Last(), product.Take(2).Last()),
                new Order(3, 1, 0, 3, 4, DateTime.Now, client.Take(3).Last(), product.Take(3).Last()),
                new Order(4, 1, 0, 4, 5, DateTime.Now, client.Take(4).Last(), product.Take(4).Last()),
                new Order(5, 1, 0, 5, 6, DateTime.Now, client.Last(), product.Last())
            };

            context.Orders.AddRange(orders);
            context.SaveChanges();

            var order = context.Orders.OrderBy(x => x.Id).ToList();

            var paymentClients = new PaymentClient[]
            {
                new PaymentClient(order.First()),
                new PaymentClient(order.Take(2).Last()),
                new PaymentClient(order.Take(3).Last()),
                new PaymentClient(order.Take(4).Last()),
                new PaymentClient(order.Last()),
            };

            context.PaymentClients.AddRange(paymentClients);
            context.SaveChanges();

            var invoice = context.Invoices.OrderBy(x => x.Id).ToList();

            var paymentProviders = new PaymentProvider[]
            {
                new PaymentProvider(0, invoice.First()),
                new PaymentProvider(1, invoice.Take(2).Last()),
                new PaymentProvider(2, invoice.Take(3).Last()),
                new PaymentProvider(3, invoice.Take(4).Last()),
                new PaymentProvider(4, invoice.Last()),
            };

            context.PaymentProviders.AddRange(paymentProviders);
            context.SaveChanges();
        }
    }
}