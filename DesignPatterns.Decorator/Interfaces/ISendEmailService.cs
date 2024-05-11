namespace DesignPatterns.Decorator.Interfaces
{
    public interface ISendEmailService
    {
        void SendEmailPaymentProcessed(string email, string message);
    }
}