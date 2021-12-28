using ApiSample.Data.Models.Enum;

namespace ApiSample.Data.Models
{
    public class Payment : Model
    {
        public PaymentType PaymentType { get; set; }
        public TransactionType TransactionType { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal Others { get; set; }
        public decimal TotalValue { get; set; }

        public Payment()
        {
            PaymentType = PaymentType.Money;
            TransactionType = TransactionType.In;
            Total = 0;
            Discount = 0;
            Others = 0;
            TotalValue = 0;
        }

        public Payment(PaymentType paymentType, TransactionType transactionType, decimal total, decimal discount, decimal others, decimal totalValue)
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
