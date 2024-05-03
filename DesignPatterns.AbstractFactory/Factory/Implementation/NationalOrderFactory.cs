using DesignPatterns.AbstractFactory.Enums;
using DesignPatterns.AbstractFactory.Factory.Interfaces;
using DesignPatterns.AbstractFactory.Services.Deliveries;
using DesignPatterns.AbstractFactory.Services.Payments.Interfaces;

namespace DesignPatterns.AbstractFactory.Factory.Implementation
{
    public class NationalOrderFactory : IOrderAbstractFactory
    {
        public IDeliveryService GetDeliveryService()
        {
            return new NationalDeliveryService();
        }

        public IPaymentService GetPaymentService(EPaymentMethod method)
        {
            var factoryPayment = new ProcessPaymentFactoryMethod();

            return factoryPayment.GetPaymentService(method);
        }
    }
}
