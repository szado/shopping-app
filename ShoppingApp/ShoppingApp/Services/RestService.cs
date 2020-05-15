using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using ShoppingApp.Models;
using System.Threading.Tasks;

namespace ShoppingApp.Services
{
    class RestService
    {
        /*        public Dictionary<string, object> routes = new Dictionary<string, object>
                {
                    { "categories", new Test }
                };*/

        protected HttpService HttpService;

        public RestService(HttpService httpService)
        {
            this.HttpService = httpService;
        }

        public Task GetOffers()
        {
            return HttpService.GetHttpTask("offers");
        }
    }
}
