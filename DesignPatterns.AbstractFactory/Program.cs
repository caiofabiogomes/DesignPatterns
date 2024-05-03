using DesignPatterns.AbstractFactory.Enums;
using DesignPatterns.AbstractFactory.Factory.Implementation;
using DesignPatterns.AbstractFactory.InputModels;


PaypalInputModel model = new PaypalInputModel("test@gmail.com", "12345678");

var paymentResult = new OrderAbstractFactoryFactory()
    .GetFactoryMethod(EOrderType.National)
    .GetPaymentService(EPaymentMethod.PayPal)
    .ProcessPayment(model);

Console.WriteLine(paymentResult);


