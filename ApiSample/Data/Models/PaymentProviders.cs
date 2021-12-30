using ApiSample.Data.Models.Enum;

namespace ApiSample.Data.Models
{
    public class PaymentProviders : Payment
    {
        public decimal Tax { get; set; } = 0;
        public Invoices Invoice { get; set; }

        public PaymentProviders()
        {
            Tax = 0;
            Invoice = new Invoices();
        }

        public PaymentProviders(decimal tax, Invoices invoice)
        {
            Tax = tax;
            Invoice = invoice;
        }

        public PaymentProviders(decimal tax, Invoices invoice, PaymentTypes paymentType, TransactionTypes transactionType, decimal total, decimal discount, decimal others, decimal totalValue)
            : base(paymentType, transactionType, total, discount, others, totalValue)
        {
            Tax = tax;
            Invoice = invoice;
        }
    }
}
