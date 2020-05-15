using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingApp.Services
{
    class HttpService
    {
        protected const string API_URL = "https://shop-api.hubek.pl/api/";
        public Dictionary<string, string> routes = new Dictionary<string, string>
        {
            { "categories", new Test() },
        };
    }
}
