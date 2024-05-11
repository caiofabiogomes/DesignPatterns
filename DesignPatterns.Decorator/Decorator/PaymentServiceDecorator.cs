using DesignPatterns.Decorator.InputModels;
using DesignPatterns.Decorator.Interfaces;

namespace DesignPatterns.Decorator.Decorator
{
    public class PaymentServiceDecorator : IPaymentService
    {
        private readonly IPaymentService _paymentService;
        private readonly ISendEmailService _sendEmailService;

        public PaymentServiceDecorator(
            IPaymentService paymentService,
            ISendEmailService sendEmailService
            )
        {
            _paymentService = paymentService;
            _sendEmailService = sendEmailService;
        }

        public string ProcessPayment(PaymentInfoInputModel proccessPaymentInput)
        {
            string response = _paymentService.ProcessPayment(proccessPaymentInput);

            _sendEmailService.SendEmailPaymentProcessed(proccessPaymentInput.Email, response);

            return response;
        }
    }
}
