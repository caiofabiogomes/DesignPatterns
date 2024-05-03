using DesignPatterns.AbstractFactory.Enums;
using DesignPatterns.AbstractFactory.Services.Deliveries;
using DesignPatterns.AbstractFactory.Services.Payments;
using DesignPatterns.AbstractFactory.Services.Payments.Interfaces;

namespace DesignPatterns.AbstractFactory.Factory.Interfaces
{
    public class InternationalOrderAbstractFactory : IOrderAbstractFactory
    {
        public InternationalOrderAbstractFactory()
        {
        }

        public IDeliveryService GetDeliveryService()
        {
            return new InternationalDeliveryService();
        }

        public IPaymentService GetPaymentService(EPaymentMethod method)
        {
            return new CreditCardPaymentService();
        }
    }
}
