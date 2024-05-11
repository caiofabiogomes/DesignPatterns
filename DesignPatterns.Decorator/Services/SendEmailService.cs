using DesignPatterns.Decorator.Interfaces;

namespace DesignPatterns.Decorator.Services
{
    public class SendEmailService : ISendEmailService
    {
        public void SendEmailPaymentProcessed(string email, string message)
        {
            Console.WriteLine($"Sending email to {email} with message: {message}");
        }
    }
}
