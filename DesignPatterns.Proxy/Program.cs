

using DesignPatterns.Proxy.Proxies;

var customerRepositoryProxy = new CustomerRepositoryProxy();
 

Console.WriteLine(customerRepositoryProxy.GetCustomerDetailsFromApi(1, "Admin").Result);
Console.WriteLine(customerRepositoryProxy.GetCustomerDetailsFromApi(1, "Admin").Result);