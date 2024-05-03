using DesignPatterns.AbstractFactory.Enums;
using DesignPatterns.AbstractFactory.Services.Payments.Interfaces;

namespace DesignPatterns.AbstractFactory.Factory.Interfaces
{
    public interface IProcessPaymentFactoryMethod
    {
        IPaymentService GetPaymentService(EPaymentMethod paymentMethod);
    }
}
