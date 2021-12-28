using ApiSample.Data.Models;
using ApiSample.Data.Models.Enum;
using ApiSample.Services.Dto.Enum;

namespace ApiSample.Services.Dto
{
    public class PaymentDto : ModelDto
    {
        public PaymentTypeDto PaymentType { get; set; }
        public TransactionTypeDto TransactionType { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal Others { get; set; }
        public decimal TotalValue { get; set; }

        public static implicit operator Payment(PaymentDto payment)
        {
            return new()
            {
                PaymentType = (PaymentType)payment.PaymentType,
                TransactionType = (TransactionType)payment.TransactionType,
                Total = payment.Total,
                Discount = payment.Discount,
                Others = payment.Others,
                TotalValue = payment.TotalValue
            };
        }

        public PaymentDto()
        {
            PaymentType = PaymentTypeDto.Money;
            TransactionType = TransactionTypeDto.In;
            Total = 0;
            Discount = 0;
            Others = 0;
            TotalValue = 0;
        }

        public PaymentDto(PaymentTypeDto paymentType, TransactionTypeDto transactionType, decimal total, decimal discount, decimal others, decimal totalValue)
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
