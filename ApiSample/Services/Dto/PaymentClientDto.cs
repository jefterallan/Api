using ApiSample.Data.Models;
using ApiSample.Services.Dto.Enum;

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

        public PaymentClientDto(OrderDto order, PaymentTypeDto paymentType, TransactionTypeDto transactionType, decimal total, decimal discount, decimal others, decimal totalValue)
            : base(paymentType, transactionType, total, discount, others, totalValue)
        {
            Order = order;
        }
    }
}
