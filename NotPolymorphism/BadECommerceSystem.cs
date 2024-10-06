using OOP.Polymorphism;

namespace OOP.NotPolymorphism
{
    public class BadECommerceSystem
    {
        public void Checkout(decimal amount, string paymentMethod)
        {
            // Manual checking of payment method and invoking specific class
            if (paymentMethod == "CreditCard")
            {
                CreditCardPayment creditCardPayment = new CreditCardPayment();
                creditCardPayment.ProcessPayment(amount);
            }
            else if (paymentMethod == "PayPal")
            {
                PayPalPayment payPalPayment = new PayPalPayment();
                payPalPayment.ProcessPayment(amount);
            }
            else if (paymentMethod == "BankTransfer")
            {
                BankTransferPayment bankTransferPayment = new BankTransferPayment();
                bankTransferPayment.ProcessPayment(amount);
            }
            else
            {
                Console.WriteLine("Invalid payment method.");
            }
        }
    }
}
