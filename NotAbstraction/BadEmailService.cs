namespace OOP.NotAbstraction
{
    public class BadEmailService
    {
        public void Connect()
        {
            Console.WriteLine("Connecting...");
        }
        public void Authenticate()
        {
            Console.WriteLine("Authenticating...");
        }

        public void SendEmail()
        {
            Console.WriteLine("Sending Email...");
        }
        public void Disconnect()
        {
            Console.WriteLine("Disconnecting...");
        }
    }
}
