using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

using ShoppingApp.Models.Database;
using ShoppingApp.Services;

namespace ShoppingApp.ViewModels
{
    public class CartViewModel : BaseViewModel<Cart>
    {
        public TableQuery<Cart> Items { get; set; }

        public CartViewModel()
        {
            Title = "Koszyk";

            var app = App.Current as App;
            Items = app.Database.Connection.Table<Cart>();
        }
        
        public bool RemoveCartItem(int cartItemId)
        {
            return new CartService((App.Current as App).Database).RemoveFromCart(cartItemId);
        }
    }
}
