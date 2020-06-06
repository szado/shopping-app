using ShoppingApp.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Text;
using Newtonsoft.Json;

namespace ShoppingApp.Services
{
    public class CategoryStore : IDataStore<Category>
    {
        protected ApiService apiService;

        public CategoryStore(ApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task<bool> AddItemAsync(Category item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateItemAsync(Category item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Category>> GetItemsAsync(bool forceRefresh = false)
        {
            string response = await apiService.GetAsync("categories");

            var categories = JsonConvert.DeserializeObject<DataArrayApiResponse<Category>>(response);

            return new List<Category>(categories.data);
        }
    }
}
