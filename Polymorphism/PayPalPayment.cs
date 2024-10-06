﻿namespace OOP.Polymorphism
{
    public class PayPalPayment : IPaymentProcessor
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing PayPal payment...");
        }
    }
}
