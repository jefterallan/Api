using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class InvoicesDto : ModelDto
    {
        public int Number { get; set; }
        public decimal Tax { get; set; }
        public decimal Shipping { get; set; }
        public decimal Others { get; set; }
        public decimal Total { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime Date { get; set; }

        public ProvidersDto Provider { get; set; }
        public ICollection<ProductsDto> Product { get; set; }

        public static implicit operator Invoices(InvoicesDto invoice)
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
                Product = invoice.Product.Select<ProductsDto, Products>(x => x).ToList()
            };
        }

        public InvoicesDto()
        {
            Number = 0;
            Tax = 0;
            Shipping = 0;
            Others = 0;
            Total = 0;
            TotalValue = 0;
            Date = DateTime.Now;
            Provider = new ProvidersDto();
            Product = new List<ProductsDto>();
        }

        public InvoicesDto(int number, decimal tax, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, ProvidersDto provider, ProductsDto product)
        {
            Number = number;
            Tax = tax;
            Shipping = shipping;
            Others = others;
            Total = total;
            TotalValue = totalValue;
            Date = date;
            Provider = provider;
            Product = new List<ProductsDto>() { product };
        }

        public InvoicesDto(int number, decimal tax, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, ProvidersDto provider, ICollection<ProductsDto> product)
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
