using System;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace ShoppingApp.Services
{
    class HttpService
    {
        protected const string API_URL = "https://shop-api.hubek.pl/api";
        protected HttpClient client = new HttpClient();

        public Task GetHttpTask(string resourceUri)
        {
            return this.client.GetAsync(
                new Uri(this.getFullResourceUrl(resourceUri))
            );
        }

        protected string getFullResourceUrl(string uri)
        {
            return $"{API_URL}/{uri}";
        }
    }
}
