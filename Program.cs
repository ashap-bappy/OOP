using OOP.Abstraction;
using OOP.Encapsulation;
using OOP.Inheritance;
using OOP.NotAbstraction;
using OOP.NotEncapsulation;

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
