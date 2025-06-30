namespace Advanced_OOP_Concepts_With_CSharp
{
    public class CreditCardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Kredi kartı ile {amount} Tl ödendi.");
        }
    }
    public class CashPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Nakit ile {amount} Tl ödendi.");

        }
    }
    public class PayPalPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"PayPal ile {amount} Tl ödendi.");

        }
    }
    public class PaymentProcessor
    {
       private readonly IPayment paymentType;
        public PaymentProcessor(IPayment ipayment)
        {
            paymentType = ipayment;
        }
        public void Process(decimal amount)
        {
            paymentType.Pay(amount);
        }
    }

}
