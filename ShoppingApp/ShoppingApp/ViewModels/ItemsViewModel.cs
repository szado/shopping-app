using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using ShoppingApp.Models;
using ShoppingApp.Views;
using ShoppingApp.Services;

namespace ShoppingApp.ViewModels
{
    public class ItemsViewModel : BaseViewModel<Offer>
    {
        public ObservableCollection<Offer> Offers { get; set; }
        public Command LoadItemsCommand { get; set; }
        public OffersStore DataStore;

        public ItemsViewModel()
        {
            Title = "Oferty";
            Offers = new ObservableCollection<Offer>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            DataStore = new OffersStore(new ApiService(new System.Net.Http.HttpClient()));
            ExecuteLoadItemsCommand();

/*            MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Item;
                Items.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });*/
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Offers.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Offers.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}