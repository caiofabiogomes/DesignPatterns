using DesignPatterns.Decorator.Decorator;
using DesignPatterns.Decorator.Enums;
using DesignPatterns.Decorator.Interfaces;
using DesignPatterns.Decorator.Services;

namespace DesignPatterns.Decorator.Factory
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
            return new PaymentServiceDecorator(paymentService, new SendEmailService());
        }



    }
}
