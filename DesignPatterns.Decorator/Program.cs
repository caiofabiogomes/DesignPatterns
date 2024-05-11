using DesignPatterns.Decorator.Enums;
using DesignPatterns.Decorator.Factory;
using DesignPatterns.Decorator.InputModels;

var paymentService = new ProcessPaymentFactoryMethod().GetPaymentService(EPaymentMethod.CreditCard);

var paymentInfo = new CreditCardInputModel("test@email.com", "1111 1111 1111 1111", "TEST T T", "06/30", "111");

paymentService.ProcessPayment(paymentInfo);