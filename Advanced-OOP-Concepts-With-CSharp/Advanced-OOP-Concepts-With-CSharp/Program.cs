namespace Advanced_OOP_Concepts_With_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IAnimal> hayvanlar = new List<IAnimal>()
            {
                new Dog(),
                new Cat()
            };

            IPayment payment=new CreditCardPayment();
            PaymentProcessor processor = new PaymentProcessor(payment);
            processor.Process(150.55m);
            ILogger logger=new  ConsoleLogger();
            ZooManager manager = new ZooManager(hayvanlar, logger);
            manager.ShowAnimals();

        }
    }
}
