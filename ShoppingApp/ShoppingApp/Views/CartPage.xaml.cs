using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ShoppingApp.ViewModels;
using ShoppingApp.Models.Database;

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

        async void Cart_RemoveItem(object sender, EventArgs e)
        {
            int cartItemId;
            bool deleted = true;
            Button btn = (Button)sender;

            try
            {
                Int32.TryParse(btn.CommandParameter.ToString(), out cartItemId);
                deleted = viewModel.RemoveCartItem(cartItemId);
            } catch
            {
                deleted = false;
            }

            if (deleted)
            {
                await DisplayAlert("Usuwanie", "Usunięto przedmiot z koszyka", "OK");
            } else
            {
                await DisplayAlert(
                    "Usuwanie", 
                    "Nie udało się usunąć przedmiotu z koszyka. Spróbuj ponownie.", 
                    "OK"
                );
            }
        }

        async void Cart_Close(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}
