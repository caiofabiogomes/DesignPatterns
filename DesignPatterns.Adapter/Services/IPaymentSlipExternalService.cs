using DesignPatterns.Adapter.Models;

namespace DesignPatterns.Adapter.Services
{
    public interface IPaymentSlipExternalService
    {
        BankSlipExternalModel GeneratePaymentSlip();
    }
}
