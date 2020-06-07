﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ShoppingApp.Models;
using ShoppingApp.Views;
using ShoppingApp.ViewModels;

namespace ShoppingApp.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel();
        }

        public ItemsPage(Category category)
        {
            InitializeComponent();

            BindingContext = viewModel = new ItemsViewModel(category);
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var offer = args.SelectedItem as Offer;

            if (offer == null)
            {
                return;
            }

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(offer)));
            ItemsListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.Offers.Count == 0)
                viewModel.LoadItemsCommand.Execute(null);
        }
    }
}