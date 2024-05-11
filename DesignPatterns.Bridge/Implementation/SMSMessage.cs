using DesignPatterns.Bridge.Abstract;
using DesignPatterns.Bridge.Interfaces;

namespace DesignPatterns.Bridge.Implementation
{
    public class SMSMessage : MessageBridge
    {
        public SMSMessage(IMessageSender sender) : base(sender)
        {
        }

        public override void Send(string message)
        {
            _sender.SendMessage($"[SMS] {message}");
        }
    }
}
