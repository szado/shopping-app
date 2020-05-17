using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShoppingApp.Services
{
    public class ApiService
    {
        protected const string API_URL = "https://shop-api.hubek.pl/api";
        protected HttpClient httpClient;

        public ApiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<string> GetAsync(string resourceUri)
        {
            return httpClient.GetStringAsync(
                new Uri(this.getFullResourceUrl(resourceUri))
            );
        }

        protected string getFullResourceUrl(string uri)
        {
            return $"{API_URL}/{uri}";
        }
    }
}
