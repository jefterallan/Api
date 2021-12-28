using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class InvoiceDto : ModelDto
    {
        public int Number { get; set; }
        public decimal Tax { get; set; }
        public decimal Shipping { get; set; }
        public decimal Others { get; set; }
        public decimal Total { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime Date { get; set; }

        public ProviderDto Provider { get; set; }
        public ICollection<ProductDto> Product { get; set; }

        public static implicit operator Invoice(InvoiceDto invoice)
        {
            return new()
            {
                Number = invoice.Number,
                Tax = invoice.Tax,
                Shipping = invoice.Shipping,
                Others = invoice.Others,
                Total = invoice.Total,
                TotalValue = invoice.TotalValue,
                Date = invoice.Date,
                Provider = invoice.Provider,
                Product = invoice.Product.Select<ProductDto, Product>(x => x).ToList()
            };
        }

        public InvoiceDto()
        {
            Number = 0;
            Tax = 0;
            Shipping = 0;
            Others = 0;
            Total = 0;
            TotalValue = 0;
            Date = DateTime.Now;
            Provider = new ProviderDto();
            Product = new List<ProductDto>();
        }

        public InvoiceDto(int number, decimal tax, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, ProviderDto provider, ProductDto product)
        {
            Number = number;
            Tax = tax;
            Shipping = shipping;
            Others = others;
            Total = total;
            TotalValue = totalValue;
            Date = date;
            Provider = provider;
            Product = new List<ProductDto>() { product };
        }

        public InvoiceDto(int number, decimal tax, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, ProviderDto provider, ICollection<ProductDto> product)
        {
            Number = number;
            Tax = tax;
            Shipping = shipping;
            Others = others;
            Total = total;
            TotalValue = totalValue;
            Date = date;
            Provider = provider;
            Product = product;
        }
    }
}
