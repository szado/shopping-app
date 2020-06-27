using System;

using ShoppingApp.Models;
using ShoppingApp.Models.Database;

namespace ShoppingApp.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel<Offer>
    {
        public Offer Offer { get; set; }
        public ItemDetailViewModel(Offer offer = null)
        {
            Title = offer?.title;
            Offer = offer;
        }

        public bool AddToCart()
        {
            var app = App.Current as App;
            var cartItem = new Cart()
            {
                Quantity = 1,
                RemoteItemId = Offer.id,
                Name = Offer.title,
                Price = float.Parse(Offer.price),
            };

            try
            {
                app.Database.Connection.Insert(cartItem);
            } 
            catch
            {
                return false;
            }

            return true;
        }
    }
}
