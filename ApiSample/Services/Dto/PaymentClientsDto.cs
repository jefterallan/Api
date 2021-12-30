using ApiSample.Data.Models;
using ApiSample.Services.Dto.Enum;

namespace ApiSample.Services.Dto
{
    public class PaymentClientsDto : PaymentDto
    {
        public OrdersDto Order { get; set; }

        public static implicit operator PaymentClients(PaymentClientsDto paymentClient)
        {
            return new()
            {
                Order = paymentClient.Order
            };
        }

        public PaymentClientsDto()
        {
            Order = new OrdersDto();
        }

        public PaymentClientsDto(OrdersDto order)
        {
            Order = order;
        }

        public PaymentClientsDto(OrdersDto order, PaymentTypesDto paymentType, TransactionTypesDto transactionType, decimal total, decimal discount, decimal others, decimal totalValue)
            : base(paymentType, transactionType, total, discount, others, totalValue)
        {
            Order = order;
        }
    }
}
