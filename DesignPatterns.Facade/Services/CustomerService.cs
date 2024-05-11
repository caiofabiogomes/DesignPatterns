using Newtonsoft.Json.Linq;

namespace DesignPatterns.Facade.Services
{
    public class CustomerService
    {
        private readonly HttpClient _httpClient;
        public CustomerService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<string> GetCustomerDetailsFromApi(int customerId)
        {

            HttpResponseMessage response = await _httpClient.GetAsync($"https://66397b7b1ae792804bebe468.mockapi.io/api/customers/{customerId}");
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject customerJson = JObject.Parse(responseBody);
                string customerDetails = $"Detalhes do Cliente (ID: {customerId}): Nome: {customerJson["name"]}, Email: {customerJson["email"]}";
                return customerDetails;
            }
            else
            {
                throw new Exception($"Erro ao buscar detalhes do cliente. StatusCode: {response.StatusCode}");
            }
        }
    }
}
