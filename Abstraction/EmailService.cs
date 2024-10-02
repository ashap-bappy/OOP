namespace OOP.Abstraction
{
    public class EmailService
    {
        public void SendEmail()
        {
            Connect();
            Authenticate();
            Console.WriteLine("Sending Email...");
            Disconnect();
        }
        private void Connect()
        {
            Console.WriteLine("Connecting...");
        }
        private void Authenticate()
        {
            Console.WriteLine("Authenticating...");
        }

        private void Disconnect()
        {
            Console.WriteLine("Disconnecting...");
        }
    }
}
