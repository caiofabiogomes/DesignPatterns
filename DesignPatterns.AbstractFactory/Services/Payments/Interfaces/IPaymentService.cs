using DesignPatterns.AbstractFactory.InputModels;

namespace DesignPatterns.AbstractFactory.Services.Payments.Interfaces
{
    public interface IPaymentService
    {
        string ProcessPayment(PaymentInfoInputModel proccessPaymentInput);
    }
}
