using DesignPatterns.Decorator.InputModels;

namespace DesignPatterns.Decorator.Interfaces
{
    public interface IPaymentService
    {
        string ProcessPayment(PaymentInfoInputModel proccessPaymentInput);
    }
}
