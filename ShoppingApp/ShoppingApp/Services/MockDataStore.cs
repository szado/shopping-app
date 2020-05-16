using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingApp.Models;

namespace ShoppingApp.Services
{
    public class MockDataStore : IDataStore<Offer>
    {
        readonly List<Offer> items;
        protected RestService restService = new RestService(new HttpService());

        public MockDataStore()
        {
            items = new List<Offer>()
            {
/*                new Offer { 
                    category =  
                }*/
            };
        }

        public async Task<bool> AddItemAsync(Offer item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Offer item)
        {
            var oldItem = items.Where((Offer arg) => arg.id == item.id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
/*            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);*/
        }

        public async Task<Offer> GetItemAsync(int id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.id == id));
        }

        public async Task<IEnumerable<Offer>> GetItemsAsync(bool forceRefresh = false)
        {
            return await restService.GetOffers();
        }
    }
}