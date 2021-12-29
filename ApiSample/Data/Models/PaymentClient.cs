using ApiSample.Data.Models.Enum;

namespace ApiSample.Data.Models
{
    public class PaymentClient : Payment
    {
        public Order Order { get; set; }

        public PaymentClient()
        {
            Order = new Order();
        }

        public PaymentClient(Order order)
        {
            Order = order;
        }

        public PaymentClient(Order order, PaymentType paymentType, TransactionType transactionType, decimal total, decimal discount, decimal others, decimal totalValue)
            : base(paymentType, transactionType, total, discount, others, totalValue)
        {
            Order = order;
        }
    }
}
