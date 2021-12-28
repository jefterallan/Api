using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class PaymentClientDto : PaymentDto
    {
        public OrderDto Order { get; set; }

        public static implicit operator PaymentClient(PaymentClientDto paymentClient)
        {
            return new()
            {
                Order = paymentClient.Order
            };
        }

        public PaymentClientDto()
        {
            Order = new OrderDto();
        }

        public PaymentClientDto(OrderDto order)
        {
            Order = order;
        }
    }
}
