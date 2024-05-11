using DesignPatterns.Adapter.Builder;
using DesignPatterns.Adapter.Models;
using DesignPatterns.Adapter.Services;

namespace DesignPatterns.Adapter.Adapters
{
    public class PaymentSlipServiceAdapter
    {
        private readonly IPaymentSlipExternalService _paymentSlipExternalService;
        public PaymentSlipServiceAdapter(IPaymentSlipExternalService paymentSlipExternalService)
        {
            _paymentSlipExternalService = paymentSlipExternalService;
        }

        public BankSlipModel GeneratePaymentSlip() 
        {
            var bankSlipExternalModel = _paymentSlipExternalService.GeneratePaymentSlip();

            Console.WriteLine("Adapting BankSlipExternalModel to BankSlipModel");
            
            var builder = new BankSlipModelBuilder()
                .ForBeneficiary(bankSlipExternalModel.beneficiary)
                .FromPayer(bankSlipExternalModel.payer)
                .WithNumber(bankSlipExternalModel.number)
                .WithAmount(bankSlipExternalModel.amount)
                .WithDueDate(bankSlipExternalModel.due_date)
                .Build();

            return builder;
        }

    }
}
