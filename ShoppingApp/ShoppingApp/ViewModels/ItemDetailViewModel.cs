using System;

using ShoppingApp.Models;
using ShoppingApp.Services;

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

        public bool AddToCart(int quantity)
        {
            return new CartService((App.Current as App).Database).AddToCart(Offer, quantity);
        }
    }
}