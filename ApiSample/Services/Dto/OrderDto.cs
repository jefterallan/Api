using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class OrderDto : ModelDto
    {
        public int Number { get; set; }
        public decimal Shipping { get; set; }
        public decimal Others { get; set; }
        public decimal Total { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime Date { get; set; }

        public ClientDto Client { get; set; }
        public ICollection<ProductDto> Product { get; set; }

        public static implicit operator Order(OrderDto order)
        {
            return new()
            {
                Number = order.Number,
                Shipping = order.Shipping,
                Others = order.Others,
                Total = order.Total,
                TotalValue = order.TotalValue,
                Date = order.Date,
                Client = order.Client,
                Product = order.Product.Select<ProductDto, Product>(x => x).ToList()
            };
        }

        public OrderDto()
        {
            Number = 0;
            Shipping = 0;
            Others = 0;
            Total = 0;
            TotalValue = 0;
            Date = DateTime.Now;
            Client = new ClientDto();
            Product = new List<ProductDto>();

        }

        public OrderDto(int number, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, ClientDto client, ProductDto product)
        {
            Number = number;
            Shipping = shipping;
            Others = others;
            Total = total;
            TotalValue = totalValue;
            Date = date;
            Client = client;
            Product = new List<ProductDto>() { product };
        }

        public OrderDto(int number, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, ClientDto client, ICollection<ProductDto> product)
        {
            Number = number;
            Shipping = shipping;
            Others = others;
            Total = total;
            TotalValue = totalValue;
            Date = date;
            Client = client;
            Product = product;
        }
    }
}
