﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ShoppingApp.ViewModels;

namespace ShoppingApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CartPage : ContentPage
    {
        CartViewModel viewModel;

        public CartPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new CartViewModel();
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            var it = e.Item;

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }

        async void Cart_RemoveItem(object sender, EventArgs e)
        {
            await DisplayAlert("Usuwanie", "Przedmiot usunięty", "OK");
        }

        async void Cart_Close(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
