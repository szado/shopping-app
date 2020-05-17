using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingApp.Models;
using Newtonsoft.Json;

namespace ShoppingApp.Services
{
    public class OffersStore : IDataStore<Offer>
    {
        readonly List<Offer> items = new List<Offer>();
        protected ApiService apiService;

        public OffersStore(ApiService apiService)
        {
            this.apiService = apiService;
        }

        public async Task<bool> AddItemAsync(Offer item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> UpdateItemAsync(Offer item)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Offer> GetItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Offer>> GetItemsAsync(bool forceRefresh = false)
        {
            string response = await apiService.GetAsync("offers");

            var offers = JsonConvert.DeserializeObject<DataArrayApiResponse<Offer>>(response);

            return new List<Offer>(offers.data);
        }
    }
}