using DesignPatterns.Proxy.Services;
using Microsoft.Extensions.Caching.Memory;

namespace DesignPatterns.Proxy.Proxies
{
    public class CustomerRepositoryProxy
    {
        private readonly IMemoryCache _cache;

        public CustomerRepositoryProxy()
        {
            _cache = new MemoryCache(new MemoryCacheOptions());
        }

        public async Task<string> GetCustomerDetailsFromApi(int customerId, string role)
        {
            if (role != "Admin")
            {
                return null;
            }
            var customerRepository = new CustomerRepository();


            var customerDetails = _cache.GetOrCreate($"CustomerDetails-{customerId}", entry => 
            {
                return  customerRepository.GetCustomerDetailsFromApi(customerId).Result;
            });

            return customerDetails;

        }
    }
}
