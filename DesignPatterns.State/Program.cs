using DesignPatterns.State;

var order = new Order();

order.ProcessOrder();

order.CancelOrder();

order.ProcessOrder();

Console.ReadKey();