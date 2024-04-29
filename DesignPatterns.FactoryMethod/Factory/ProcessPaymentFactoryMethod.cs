using DesignPatterns.FactoryMethod.Enums;
using DesignPatterns.FactoryMethod.InputModels;
using DesignPatterns.FactoryMethod.Services;
using DesignPatterns.FactoryMethod.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FactoryMethod.Factory
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
