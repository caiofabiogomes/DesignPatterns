using DesignPatterns.ChainOfResponsability;
using DesignPatterns.ChainOfResponsability.models;

var manager = new Manager(1000);
var director = new Director(5000);
var ceo = new CEO(10000);

manager.SetNextHandler(director);
director.SetNextHandler(ceo);

var expense1 = new Expense(500);
var expense2 = new Expense(5000);
var expense3 = new Expense(15000);

Console.WriteLine("Expense 1 approval: " + manager.ApproveExpense(expense1));
Console.WriteLine("Expense 2 approval: " + manager.ApproveExpense(expense2));
Console.WriteLine("Expense 3 approval: " + manager.ApproveExpense(expense3));

Console.ReadKey();