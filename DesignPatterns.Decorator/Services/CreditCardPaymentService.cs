using DesignPatterns.Decorator.InputModels;
using DesignPatterns.Decorator.Interfaces;

namespace DesignPatterns.Decorator.Services
{
    public class CreditCardPaymentService : IPaymentService
    { 

        public string ProcessPayment(PaymentInfoInputModel proccessPaymentInput)
        {
            if (proccessPaymentInput is CreditCardInputModel creditCardPaymentInfo)
            {
               return $"Processing credit card payment for {creditCardPaymentInfo.CardHolderName} with card number {creditCardPaymentInfo.CardNumber}";
            }
            else
            {
                throw new ArgumentException("Credit card payment information is invalid.");
            }

        }
    }
}