namespace OOP.Polymorphism
{
    public class CreditCardPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing Credit Card Payment...");
        }
    }
}
