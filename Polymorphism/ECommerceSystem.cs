namespace OOP.Polymorphism
{
    public class ECommerceSystem
    {
        public void Checkout(decimal amount, IPaymentProcessor paymentProcessor)
        {
            Console.WriteLine("Checking out...");
            paymentProcessor.ProcessPayment(amount);
        }
    }
}
