// See https://aka.ms/new-console-template for more information
using DesignPatterns.Singleton;

var loppIsActive = true;


do
{
    ProjectConfiguration.GetInstance();

    Console.WriteLine("Type y if you want to see the loop again");
    loppIsActive = Console.ReadLine() == "y";

}
while (loppIsActive);
