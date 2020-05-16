using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using ShoppingApp.Models;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ShoppingApp.Services
{
    public class RestService
    {
        protected HttpService HttpService;

        public RestService(HttpService httpService)
        {
            this.HttpService = httpService;
        }

        public async Task<List<Offer>> GetOffers()
        {
            HttpResponseMessage httpResponse = await HttpService.GetHttpTask("offers");
            return JsonConvert.DeserializeObject(httpResponse.Content.ToString()) as List<Offer>;
        }
    }
}
