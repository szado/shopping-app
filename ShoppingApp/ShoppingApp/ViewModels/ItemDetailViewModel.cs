using System;

using ShoppingApp.Models;

namespace ShoppingApp.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel<Offer>
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
