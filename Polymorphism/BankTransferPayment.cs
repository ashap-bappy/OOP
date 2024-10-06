namespace OOP.Polymorphism
{
    public class BankTransferPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing bank transfer payment...");
        }
    }
}
