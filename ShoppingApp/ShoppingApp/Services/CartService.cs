using System;
using System.Collections.Generic;
using System.Text;
using ShoppingApp.Models;
using ShoppingApp.Models.Database;

namespace ShoppingApp.Services
{
    class CartService
    {
        private DatabaseService database;

        public CartService(DatabaseService database)
        {
            this.database = database;
        }

        public bool AddToCart(Offer offer, int quantity)
        {
            var cartItem = GetCartItemByOffer(offer);

            if (cartItem == null)
            {
                cartItem = new Cart()
                {
                    Quantity = 1,
                    RemoteItemId = offer.id,
                    Name = offer.title,
                    Price = float.Parse(offer.price),
                };

                try
                {
                    database.Connection.Insert(cartItem);
                }
                catch
                {
                    return false;
                }

                return true;
            }
            else
            {
                cartItem.Quantity += quantity;
                return database.Connection.Update(cartItem) > 0;
            }
        }

        public Cart GetCartItemByOffer(Offer offer)
        {
            var cartList = database.Connection.Query<Cart>($"select * from Cart where RemoteItemId = '{offer.id}';");
            return cartList.Count == 0 ? null : cartList[0];
        }
    }
}
