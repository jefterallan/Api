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
    }
}
