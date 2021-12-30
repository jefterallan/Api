using ApiSample.Data.Models;
using ApiSample.Data.Models.Enum;
using ApiSample.Services.Dto.Enum;

namespace ApiSample.Services.Dto
{
    public class PaymentDto : ModelDto
    {
        public PaymentTypesDto PaymentType { get; set; }
        public TransactionTypesDto TransactionType { get; set; }
        public decimal Total { get; set; }
        public decimal Discount { get; set; }
        public decimal Others { get; set; }
        public decimal TotalValue { get; set; }

        public static implicit operator Payment(PaymentDto payment)
        {
            return new()
            {
                PaymentType = (PaymentTypes)payment.PaymentType,
                TransactionType = (TransactionTypes)payment.TransactionType,
                Total = payment.Total,
                Discount = payment.Discount,
                Others = payment.Others,
                TotalValue = payment.TotalValue
            };
        }

        public PaymentDto()
        {
            PaymentType = PaymentTypesDto.Money;
            TransactionType = TransactionTypesDto.In;
            Total = 0;
            Discount = 0;
            Others = 0;
            TotalValue = 0;
        }

        public PaymentDto(PaymentTypesDto paymentType, TransactionTypesDto transactionType, decimal total, decimal discount, decimal others, decimal totalValue)
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
