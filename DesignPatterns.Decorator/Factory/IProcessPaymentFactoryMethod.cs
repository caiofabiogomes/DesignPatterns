using DesignPatterns.Decorator.Enums;
using DesignPatterns.Decorator.Interfaces;

namespace DesignPatterns.Decorator.Factory
{
    public interface IProcessPaymentFactoryMethod
    {
        IPaymentService GetPaymentService(EPaymentMethod paymentMethod);
    }
}
