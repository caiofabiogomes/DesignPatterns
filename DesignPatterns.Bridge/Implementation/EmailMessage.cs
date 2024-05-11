using DesignPatterns.Bridge.Abstract;
using DesignPatterns.Bridge.Interfaces;

namespace DesignPatterns.Bridge.Implementation
{
    public class EmailMessage : MessageBridge
    {
        public EmailMessage(IMessageSender sender) : base(sender)
        {
        }

        public override void Send(string message)
        {
            _sender.SendMessage($"[Email] {message}");
        }
    }
}
