using DesignPatterns.AbstractFactory.InputModels;
using DesignPatterns.AbstractFactory.Services.Payments.Interfaces;

namespace DesignPatterns.AbstractFactory.Services.Payments
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