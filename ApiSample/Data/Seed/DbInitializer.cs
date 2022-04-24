using ApiSample.Data.Models;
using ApiSample.Data.Models.Enum;
using ApiSample.Helpers;

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

            var brands = new Brands[]
            {
                new Brands("test1"),
                new Brands("test2"),
                new Brands("test3"),
                new Brands("test4"),
                new Brands("test5")
            };

            context.Brands.AddRange(brands);
            context.SaveChanges();

            var groups = new Groups[]
            {
                new Groups("Admin"),
                new Groups("Employe"),
                new Groups("Vendor"),
                new Groups("Provider"),
                new Groups("Architect")
            };

            context.Groups.AddRange(groups);
            context.SaveChanges();

            var prices = new Prices[]
            {
                new Prices(5,10,DateTime.Today, DateTime.Today.AddDays(10)),
                new Prices(6,11,DateTime.Today, DateTime.Today.AddDays(10)),
                new Prices(7,12,DateTime.Today, DateTime.Today.AddDays(10)),
                new Prices(8,13,DateTime.Today, DateTime.Today.AddDays(10)),
                new Prices(9,14,DateTime.Today, DateTime.Today.AddDays(10))
            };

            context.Prices.AddRange(prices);
            context.SaveChanges();

            var brand = context.Brands.OrderBy(x => x.Id).ToList();

            var products = new Products[]
            {
                new Products("01", "test1", 10, brand.First()),
                new Products("02", "test2", 20, brand.Take(2).Last()),
                new Products("03", "test3", 30, brand.Take(3).Last()),
                new Products("04", "test4", 40, brand.Take(4).Last()),
                new Products("05", "test5", 50, brand.Last())
            };

            context.Products.AddRange(products);
            context.SaveChanges();

            var product = context.Products.OrderBy(x => x.Id).ToList();
            var price = context.Prices.OrderBy(x => x.Id).ToList();

            var productPrices = new ProductPrices[]
            {
                new ProductPrices(product.First(), price.First()),
                new ProductPrices(product.Take(2).Last(), price.Take(2).Last()),
                new ProductPrices(product.Take(3).Last(), price.Take(3).Last()),
                new ProductPrices(product.Take(4).Last(), price.Take(4).Last()),
                new ProductPrices(product.Last(), price.Last())
            };

            context.ProductPrices.AddRange(productPrices);
            context.SaveChanges();

            var group = context.Groups.OrderBy(x => x.Id).ToList();

            var users = new Users[]
            {
                new Users("Test1", group.First(), "test1", SharedExtentions.EncryptSHA512("test1")),
                new Users("Test2", group.Take(2).Last(), "test2", SharedExtentions.EncryptSHA512("test2")),
                new Users("Test3", group.Take(3).Last(), "test3", SharedExtentions.EncryptSHA512("test3")),
                new Users("Test4", group.Take(4).Last(), "test4", SharedExtentions.EncryptSHA512("test4")),
                new Users("Test5", group.Last(), "test5", SharedExtentions.EncryptSHA512("test5"))
            };

            context.Users.AddRange(users);
            context.SaveChanges();

            var addresses = new Addresses[]
            {
                new Addresses("test1", "1", "test1", States.AC, 12345678, "test1"),
                new Addresses("test2", "2", "test2", States.AL, 12345678, "test2"),
                new Addresses("test3", "3", "test3", States.AM, 12345678, "test3"),
                new Addresses("test4", "4", "test4", States.AP, 12345678, "test4"),
                new Addresses("test5", "5", "test5", States.BA, 12345678, "test5")
            };

            context.Addresses.AddRange(addresses);
            context.SaveChanges();

            var address = context.Addresses.OrderBy(x => x.Id).ToList();

            var clients = new Clients[]
            {
                new Clients("1", Genders.Male, DateTime.Now, "test1", "1234567890", address.First(), "test1@test.com", "12345"),
                new Clients("2", Genders.Male, DateTime.Now, "test2", "1234567890", address.Take(2).Last(), "test2@test.com", "12345"),
                new Clients("3", Genders.Female, DateTime.Now, "test3", "1234567890", address.Take(3).Last(), "test3@test.com", "12345"),
                new Clients("4", Genders.Female, DateTime.Now, "test4", "1234567890", address.Take(4).Last(), "test3@test.com", "12345"),
                new Clients("5", Genders.Other, DateTime.Now, "test5", "1234567890", address.Last(), "test5@test.com", "12345")
            };

            context.Clients.AddRange(clients);
            context.SaveChanges();

            var providers = new Providers[]
            {
                new Providers("test1", "1", DateTime.Now, "test6", "1234567890", address.First(), "test6@test.com", "12345"),
                new Providers("test2", "2", DateTime.Now, "test7", "1234567890", address.Take(2).Last(), "test7@test.com", "12345"),
                new Providers("test3", "3", DateTime.Now, "test8", "1234567890", address.Take(3).Last(), "test8@test.com", "12345"),
                new Providers("test4", "4", DateTime.Now, "test9", "1234567890", address.Take(4).Last(), "test9@test.com", "12345"),
                new Providers("test5", "5", DateTime.Now, "test10", "1234567890", address.Last(), "test10@test.com", "12345")
            };

            context.Providers.AddRange(providers);
            context.SaveChanges();

            var provider = context.Providers.OrderBy(x => x.Id).ToList();

            var invoices = new Invoices[]
            {
                new Invoices(1, 1, 0, 0, 1, 2, DateTime.Now, provider.First(), product.First()),
                new Invoices(2, 1, 0, 0, 2, 3, DateTime.Now, provider.Take(2).Last(), product.Take(2).Last()),
                new Invoices(3, 1, 0, 0, 3, 4, DateTime.Now, provider.Take(3).Last(), product.Take(3).Last()),
                new Invoices(4, 1, 0, 0, 4, 5, DateTime.Now, provider.Take(4).Last(), product.Take(4).Last()),
                new Invoices(5, 1, 0, 0, 5, 6, DateTime.Now, provider.Last(), product.Last())
            };

            context.Invoices.AddRange(invoices);
            context.SaveChanges();

            var client = context.Clients.OrderBy(x => x.Id).ToList();

            var orders = new Orders[]
            {
                new Orders(1, 1, 0, 1, 2, DateTime.Now, client.First(), product.First()),
                new Orders(2, 1, 0, 2, 3, DateTime.Now, client.Take(2).Last(), product.Take(2).Last()),
                new Orders(3, 1, 0, 3, 4, DateTime.Now, client.Take(3).Last(), product.Take(3).Last()),
                new Orders(4, 1, 0, 4, 5, DateTime.Now, client.Take(4).Last(), product.Take(4).Last()),
                new Orders(5, 1, 0, 5, 6, DateTime.Now, client.Last(), product.Last())
            };

            context.Orders.AddRange(orders);
            context.SaveChanges();

            var order = context.Orders.OrderBy(x => x.Id).ToList();

            var paymentClients = new PaymentClients[]
            {
                new PaymentClients(order.First() ,PaymentTypes.Transfer, TransactionTypes.In, 1, 0, 1, 2),
                new PaymentClients(order.Take(2).Last() ,PaymentTypes.PIX, TransactionTypes.In, 1, 0, 1, 2),
                new PaymentClients(order.Take(3).Last() ,PaymentTypes.ForwardSale, TransactionTypes.In, 1, 0, 1, 2),
                new PaymentClients(order.Take(4).Last() ,PaymentTypes.Debit, TransactionTypes.Out, 1, 0, 1, 2),
                new PaymentClients(order.Last() ,PaymentTypes.Money, TransactionTypes.Out, 1, 0, 1, 2)
            };

            context.PaymentClients.AddRange(paymentClients);
            context.SaveChanges();

            var invoice = context.Invoices.OrderBy(x => x.Id).ToList();

            var paymentProviders = new PaymentProviders[]
            {
                new PaymentProviders(0, invoice.First() ,PaymentTypes.Transfer, TransactionTypes.In, 1, 0, 1, 2),
                new PaymentProviders(1, invoice.Take(2).Last() ,PaymentTypes.PIX, TransactionTypes.In, 1, 0, 1, 2),
                new PaymentProviders(2, invoice.Take(3).Last() ,PaymentTypes.ForwardSale, TransactionTypes.In, 1, 0, 1, 2),
                new PaymentProviders(3, invoice.Take(4).Last() ,PaymentTypes.Debit, TransactionTypes.Out, 1, 0, 1, 2),
                new PaymentProviders(4, invoice.Last() ,PaymentTypes.Money, TransactionTypes.Out, 1, 0, 1, 2)
            };

            context.PaymentProviders.AddRange(paymentProviders);
            context.SaveChanges();
        }
    }
}