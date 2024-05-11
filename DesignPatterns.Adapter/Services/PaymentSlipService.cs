using DesignPatterns.Adapter.Adapters;
using DesignPatterns.Adapter.Models;

namespace DesignPatterns.Adapter.Services
{
    public class PaymentSlipService
    {
        private readonly IPaymentSlipExternalService _paymentSlipExternalService;
        private readonly PaymentSlipServiceAdapter _paymentSlipServiceAdapter;
        
        public PaymentSlipService()
        {
            _paymentSlipExternalService = new PaymentSlipExternalService();
            _paymentSlipServiceAdapter = new PaymentSlipServiceAdapter(_paymentSlipExternalService);
        }

        public BankSlipModel GeneratePaymentSlip()
        {
            var bankSlipModel = _paymentSlipServiceAdapter.GeneratePaymentSlip();
            return bankSlipModel;
        }
    }
}
