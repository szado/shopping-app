using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using ShoppingApp.Models;
using ShoppingApp.Services;


namespace ApiTester
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var offersStore = new OffersStore(new ApiService(new HttpClient()));

            List<Offer> offers = await offersStore.GetItemsAsync();

            foreach (Offer offer in offers)
            {
                Console.WriteLine($"{offer.title} // {offer.category.name}");
            }

            Console.ReadKey();
        }
    }
}
