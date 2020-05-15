using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using ShoppingApp.Models;

namespace ShoppingApp.Services
{
    class RestService
    {
        public Dictionary<string, object> routes = new Dictionary<string, object>
        {
            { "categories", new Category{ } },
            { "offer", new Offer{ } }
        };
    }
}
