using DesignPatterns.FactoryMethod.InputModels;
using DesignPatterns.FactoryMethod.Services.Interfaces;

namespace DesignPatterns.FactoryMethod.Services
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