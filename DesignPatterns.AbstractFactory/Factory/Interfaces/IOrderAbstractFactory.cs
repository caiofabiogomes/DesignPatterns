using DesignPatterns.AbstractFactory.Enums;
using DesignPatterns.AbstractFactory.Services.Deliveries;
using DesignPatterns.AbstractFactory.Services.Payments.Interfaces;

namespace DesignPatterns.AbstractFactory.Factory.Interfaces
{
    public interface IOrderAbstractFactory
    {
        IPaymentService GetPaymentService(EPaymentMethod method);
        IDeliveryService GetDeliveryService();
    }
}
