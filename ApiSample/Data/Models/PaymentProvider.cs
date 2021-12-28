namespace ApiSample.Data.Models
{
    public class PaymentProvider : Payment
    {
        public decimal Tax { get; set; } = 0;
        public Invoice Invoice { get; set; }

        public PaymentProvider()
        {
            Tax = 0;
            Invoice = new Invoice();
        }

        public PaymentProvider(decimal tax, Invoice invoice)
        {
            Tax = tax;
            Invoice = invoice;
        }
    }
}
