using DesignPatterns.Bridge.Interfaces;

namespace DesignPatterns.Bridge.Abstract
{
    public abstract class MessageBridge
    {
        protected IMessageSender _sender;

        protected MessageBridge(IMessageSender sender)
        {
            _sender = sender;
        }

        public abstract void Send(string message);
    }
}
