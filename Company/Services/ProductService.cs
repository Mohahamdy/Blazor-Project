using Company.Models;
using System.Net.Http.Json;
using System.Security.Cryptography.X509Certificates;

namespace Company.Services
{
    public class ProductService : IService<Product>
    {
        private readonly HttpClient httpClient;

        public ProductService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task Add(Product entity)
        {
            await httpClient.PostAsJsonAsync<Product>("/products", entity);
        }

        public async Task Edit(int id, Product entity)
        {
            await httpClient.PutAsJsonAsync<Product>($"/products/{id}", entity);
        }

        public async Task<List<Product>> GetAll()
        {
            return await httpClient.GetFromJsonAsync<List<Product>>("/products");
        }

        public async Task<Product> GetById(int id)
        {
            return await httpClient.GetFromJsonAsync<Product>($"/products/{id}");
        }

        public async Task Remove(int id)
        {
            await httpClient.DeleteAsync($"/products/{id}");
        }
    }
}
