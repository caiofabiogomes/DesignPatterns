using DesignPatterns.Bridge.Interfaces;

namespace DesignPatterns.Bridge.Implementation
{
    public class SMSSender : IMessageSender
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Sending SMS: {message}");
        }
    }
}
