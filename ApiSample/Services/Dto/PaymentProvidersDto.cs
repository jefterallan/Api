using ApiSample.Data.Models;
using ApiSample.Services.Dto.Enum;

namespace ApiSample.Services.Dto
{
    public class PaymentProvidersDto : PaymentDto
    {
        public decimal Tax { get; set; } = 0;
        public InvoicesDto Invoice { get; set; }

        public static implicit operator PaymentProviders(PaymentProvidersDto paymentProvider)
        {
            return new()
            {
                Tax = paymentProvider.Tax,
                Invoice = paymentProvider.Invoice
            };
        }

        public PaymentProvidersDto()
        {
            Tax = 0;
            Invoice = new InvoicesDto();
        }

        public PaymentProvidersDto(decimal tax, InvoicesDto invoice)
        {
            Tax = tax;
            Invoice = invoice;
        }

        public PaymentProvidersDto(decimal tax, InvoicesDto invoice, PaymentTypesDto paymentType, TransactionTypesDto transactionType, decimal total, decimal discount, decimal others, decimal totalValue)
            : base(paymentType, transactionType, total, discount, others, totalValue)
        {
            Tax = tax;
            Invoice = invoice;
        }
    }
}
