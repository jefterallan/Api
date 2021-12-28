using ApiSample.Data.Models;

namespace ApiSample.Services.Dto
{
    public class PaymentProviderDto : PaymentDto
    {
        public decimal Tax { get; set; } = 0;
        public InvoiceDto Invoice { get; set; }

        public static implicit operator PaymentProvider(PaymentProviderDto paymentProvider)
        {
            return new()
            {
                Tax = paymentProvider.Tax,
                Invoice = paymentProvider.Invoice
            };
        }

        public PaymentProviderDto()
        {
            Tax = 0;
            Invoice = new InvoiceDto();
        }

        public PaymentProviderDto(decimal tax, InvoiceDto invoice)
        {
            Tax = tax;
            Invoice = invoice;
        }
    }
}
