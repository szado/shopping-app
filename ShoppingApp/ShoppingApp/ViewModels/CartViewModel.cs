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

            Items = getCartItems();
        }

        public TableQuery<Cart> getCartItems()
        {
            var app = App.Current as App;

            return app.Database.Connection.Table<Cart>();
        }
        
        public bool RemoveCartItem(int cartItemId)
        {
            return new CartService((App.Current as App).Database).RemoveFromCart(cartItemId);
        }
    }
}
