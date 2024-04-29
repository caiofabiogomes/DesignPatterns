using DesignPatterns.FactoryMethod.InputModels;

namespace DesignPatterns.FactoryMethod.Services.Interfaces
{
    public interface IPaymentService
    {
        string ProcessPayment(PaymentInfoInputModel proccessPaymentInput);
    }
}
