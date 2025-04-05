using System.Net.Http.Json;
using InventoryHub.Client.Models;

namespace InventoryHub.Client.Services
{
    public class ProductService
    {
        private readonly HttpClient _httpClient;

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Product>> GetProducts()
        {
            return await _httpClient.GetFromJsonAsync<List<Product>>("api/Product");
        }

        public async Task<Product> GetProduct(int id)
        {
            return await _httpClient.GetFromJsonAsync<Product>($"api/Product/{id}");
        }

        public async Task AddProduct(Product product)
        {
            await _httpClient.PostAsJsonAsync("api/Product", product);
        }

        public async Task UpdateProduct(Product product)
        {
            await _httpClient.PutAsJsonAsync($"api/Product/{product.Id}", product);
        }

        public async Task DeleteProduct(int id)
        {
            await _httpClient.DeleteAsync($"api/Product/{id}");
        }
    }
}