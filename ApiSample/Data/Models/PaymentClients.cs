using ApiSample.Data.Models.Enum;

namespace ApiSample.Data.Models
{
    public class PaymentClients : Payment
    {
        public Orders Order { get; set; }

        public PaymentClients()
        {
            Order = new Orders();
        }

        public PaymentClients(Orders order)
        {
            Order = order;
        }

        public PaymentClients(Orders order, PaymentTypes paymentType, TransactionTypes transactionType, decimal total, decimal discount, decimal others, decimal totalValue)
            : base(paymentType, transactionType, total, discount, others, totalValue)
        {
            Order = order;
        }
    }
}
