using OOP.Abstraction;
using OOP.Encapsulation;
using OOP.Inheritance;
using OOP.NotAbstraction;
using OOP.NotEncapsulation;
using OOP.NotPolymorphism;
using OOP.Polymorphism;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            NotEncapsulation();
            Encapsulation();

            NotAbstraction();
            Abstraction();

            Inheritance();

            NotPolymorphism();
            Polymorphism();
        }

        private static void NotPolymorphism()
        {
            BadECommerceSystem badEcommerceSystem = new BadECommerceSystem();

            // Process payment without polymorphism
            badEcommerceSystem.Checkout(100.50m, "CreditCard");   // Output: Processing credit card payment of $100.50
            badEcommerceSystem.Checkout(75.25m, "PayPal");        // Output: Processing PayPal payment of $75.25
            badEcommerceSystem.Checkout(300.00m, "BankTransfer"); // Output: Processing bank transfer payment of $300.00
        }

        private static void Polymorphism()
        {
            var ecommerceSystem = new ECommerceSystem();

            /*Interface Implementation*/
            // Using polymorphism to handle different payment methods
            IPaymentProcessor creditCardPayment = new CreditCardPayment();
            IPaymentProcessor payPalPayment = new PayPalPayment();
            IPaymentProcessor bankTransferPayment = new BankTransferPayment();

            // Process payments with different methods
            ecommerceSystem.Checkout(100.50m, creditCardPayment);  // Output: Processing credit card payment of $100.50
            ecommerceSystem.Checkout(75.25m, payPalPayment);       // Output: Processing PayPal payment of $75.25
            ecommerceSystem.Checkout(300.00m, bankTransferPayment); // Output: Processing bank transfer payment of $300.00 
        }

        private static void Inheritance()
        {
            var car = new Car();

            // Inherited from Vehicle class
            car.Brand = "Ford";
            car.Model = "X";
            car.Start();
            car.Stop();

            // Car class own properties
            car.NumberOfDoors = 1;
            car.NumberOfWheels = 1;


            var bike = new Bike();

            // Inherited from Vehicle class
            bike.Brand = "Honda";
            bike.Model = "Y";
            bike.Start();
            bike.Stop();

            // Bike class own properties
            bike.NumberOfWheels = 1;
        }

        private static void Abstraction()
        {
            EmailService emailService = new EmailService();
            //Instead of exposing the whole process of sending email, we hide those details from user of EmailService and exposed only the necessary thing to the user which is sending the email. In this case user don't have to care about the order of the pipeling of sending email
            emailService.SendEmail();
        }

        private static void NotAbstraction()
        {
            BadEmailService badEmailService = new BadEmailService();
            //Here inorder to send email we do bunch of other things and user has access those things. If user in any case use this methods out of order the email will not be sent.
            badEmailService.Connect();
            badEmailService.Authenticate();
            badEmailService.SendEmail();
            badEmailService.Disconnect();
        }

        private static void Encapsulation()
        {
            BankAccount account = new BankAccount(100);

            //These will give exception and we don't need to provide any logic here to check the validity
            account.Deposit(-100); // amount is negative
            account.Withdraw(500); // insufficients fund
        }

        private static void NotEncapsulation()
        {
            BadBankAccount account = new BadBankAccount();
            //Since Balance property is public here, the user of BankAccount Class can assign any value to it
            //Also if anyone wants to use some validation they have to write the same logic every time the create an instance of BankAccount Class
            account.Balance = -50;
        }
    }
}
