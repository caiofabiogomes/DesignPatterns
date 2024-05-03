using DesignPatterns.AbstractFactory.Enums;
using DesignPatterns.AbstractFactory.Factory.Interfaces;
using DesignPatterns.AbstractFactory.Services.Payments;
using DesignPatterns.AbstractFactory.Services.Payments.Interfaces;

namespace DesignPatterns.AbstractFactory.Factory.Implementation
{
    public class ProcessPaymentFactoryMethod : IProcessPaymentFactoryMethod
    {
        public IPaymentService GetPaymentService(EPaymentMethod paymentMethod)
        {
            IPaymentService paymentService;

            switch (paymentMethod)
            {
                case EPaymentMethod.CreditCard:
                    paymentService = new CreditCardPaymentService();
                    break;
                case EPaymentMethod.PayPal:
                    paymentService = new PayPalPaymentService();
                    break;
                default:
                    throw new NotImplementedException();

            }
            return paymentService;
        }



    }
}
