using Company.Models;
using System.Net.Http.Json;

namespace Company.Services
{
    public class CategoryService:IService<Category>
    {
        private readonly HttpClient httpClient;

        public CategoryService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task Add(Category entity)
        {
            await httpClient.PostAsJsonAsync<Category>("/Categories", entity);
        }

        public async Task Edit(int id, Category entity)
        {
            await httpClient.PutAsJsonAsync<Category>($"/Categories/{id}", entity);
        }

        public async Task<List<Category>> GetAll()
        {
            return await httpClient.GetFromJsonAsync<List<Category>>("/Categories");
        }

        public async Task<Category> GetById(int id)
        {
            return await httpClient.GetFromJsonAsync<Category>($"/Categories/{id}");
        }

        public async Task Remove(int id)
        {
            await httpClient.DeleteAsync($"/Categories/{id}");
        }
    }
}
