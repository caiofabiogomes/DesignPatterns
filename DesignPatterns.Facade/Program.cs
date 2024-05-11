

using DesignPatterns.Facade.Facade;

var orderFacade = new OrderFacade();

await orderFacade.GenerateOrderReport(1, 1);
 