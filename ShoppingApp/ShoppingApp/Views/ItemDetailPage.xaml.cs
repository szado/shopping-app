using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ShoppingApp.Models;
using ShoppingApp.ViewModels;

namespace ShoppingApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Offer
            {
                title = "Pobieram ofertę...",
                description = "Pobieram opis oferty..."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;
        }

        private void AddToClicked(object sender, EventArgs e)
        {
            int quantity;
            string message;

            if (int.TryParse(quantityInput.Text, out quantity) && quantity > 0)
            {
                message = viewModel.AddToCart(quantity) ? $"Dodałeś do koszyka {viewModel.Offer.title}." : "Nie udało się dodać produktu do koszyka.";
            } 
            else
            {
                message = "Niepoprawna ilość produktu";
            }

            DisplayAlert("Informacja", message, "OK");
            quantityInput.Text = "1";
        }
    }
}