using DesignPatterns.AbstractFactory.InputModels;
using DesignPatterns.AbstractFactory.Services.Payments.Interfaces;

namespace DesignPatterns.AbstractFactory.Services.Payments
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