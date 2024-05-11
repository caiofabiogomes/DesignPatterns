using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Facade.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetProductDetailsFromApi(int productId)
        {

            HttpResponseMessage response = await _httpClient.GetAsync($"https://66397b7b1ae792804bebe468.mockapi.io/api/products/{productId}");
            if (response.IsSuccessStatusCode)
            {
                string responseBody = await response.Content.ReadAsStringAsync();
                JObject productJson = JObject.Parse(responseBody);
                string productDetails = $"Detalhes do Produto (ID: {productId}): Nome: {productJson["name"]}, Preço: ${productJson["price"]}";
                return productDetails;
            }
            else
            {
                throw new Exception($"Erro ao buscar detalhes do produto. StatusCode: {response.StatusCode}");
            }
        }
    }
}
