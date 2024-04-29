using DesignPatterns.FactoryMethod.Enums;
using DesignPatterns.FactoryMethod.Factory;
using DesignPatterns.FactoryMethod.InputModels;
using DesignPatterns.FactoryMethod.Services.Interfaces;

Console.WriteLine("Factory Method Design Pattern");
Console.WriteLine("-------------------------------");
Console.WriteLine("Enter 0 for card payment and 1 for PayPal");
Console.WriteLine("-------------------------------");

if (!int.TryParse(Console.ReadLine(), out var paymentMethod) || paymentMethod < 0 || paymentMethod > 1)
{
    Console.WriteLine("Invalid payment method");
    return;
}

IPaymentService service;
PaymentInfoInputModel inputModel;
var response = "";

if (paymentMethod == 0)
{
    service = new ProcessPaymentFactoryMethod().GetPaymentService(EPaymentMethod.CreditCard);
    inputModel = new CreditCardInputModel("1234567890123456", "John Doe", "12/2022", "123");
    response = service.ProcessPayment(inputModel);
}
else
{
    service = new ProcessPaymentFactoryMethod().GetPaymentService(EPaymentMethod.PayPal);
    inputModel = new PaypalInputModel("test@gmail.com", "123");
    response = service.ProcessPayment(inputModel);
}


Console.WriteLine(response);


