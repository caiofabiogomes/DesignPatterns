using DesignPatterns.Decorator.InputModels;
using DesignPatterns.Decorator.Interfaces;

namespace DesignPatterns.Decorator.Services
{
    public class PayPalPaymentService : IPaymentService
    {
        public string ProcessPayment(PaymentInfoInputModel proccessPaymentInput)
        {
            if (proccessPaymentInput is PaypalInputModel paypalInputModel)
            {
                return $"Processing PayPal payment for {paypalInputModel.Email}";
            }
            else
            {
                throw new ArgumentException("PayPal information is invalid.");
            }
        }
    }
}