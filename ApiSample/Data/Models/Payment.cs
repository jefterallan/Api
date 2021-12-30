using ApiSample.Data.Models.Enum;

namespace ApiSample.Data.Models
{
    public class Payment : Model
    {
        public PaymentTypes PaymentType { get; set; }
        public TransactionTypes TransactionType { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal Others { get; set; }
        public decimal TotalValue { get; set; }

        public Payment()
        {
            PaymentType = PaymentTypes.Money;
            TransactionType = TransactionTypes.In;
            Total = 0;
            Discount = 0;
            Others = 0;
            TotalValue = 0;
        }

        public Payment(PaymentTypes paymentType, TransactionTypes transactionType, decimal total, decimal discount, decimal others, decimal totalValue)
        {
            PaymentType = paymentType;
            TransactionType = transactionType;
            Total = total;
            Discount = discount;
            Others = others;
            TotalValue = totalValue;
        }
    }
}
