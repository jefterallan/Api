using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class OrdersDto : ModelDto
    {
        public int Number { get; set; }
        public decimal Shipping { get; set; }
        public decimal Others { get; set; }
        public decimal Total { get; set; }
        public decimal TotalValue { get; set; }
        public DateTime Date { get; set; }

        public ClientsDto Client { get; set; }
        public ICollection<ProductsDto> Product { get; set; }

        public static implicit operator Orders(OrdersDto order)
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
                Product = order.Product.Select<ProductsDto, Products>(x => x).ToList()
            };
        }

        public OrdersDto()
        {
            Number = 0;
            Shipping = 0;
            Others = 0;
            Total = 0;
            TotalValue = 0;
            Date = DateTime.Now;
            Client = new ClientsDto();
            Product = new List<ProductsDto>();

        }

        public OrdersDto(int number, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, ClientsDto client, ProductsDto product)
        {
            Number = number;
            Shipping = shipping;
            Others = others;
            Total = total;
            TotalValue = totalValue;
            Date = date;
            Client = client;
            Product = new List<ProductsDto>() { product };
        }

        public OrdersDto(int number, decimal shipping, decimal others, decimal total, decimal totalValue, DateTime date, ClientsDto client, ICollection<ProductsDto> product)
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
