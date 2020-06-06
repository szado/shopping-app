using System;

using ShoppingApp.Models;

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
    }
}
