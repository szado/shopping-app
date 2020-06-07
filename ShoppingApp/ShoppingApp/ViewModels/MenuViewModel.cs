using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using ShoppingApp.Models;
using ShoppingApp.Views;
using ShoppingApp.Services;
using System.Net.Http;

namespace ShoppingApp.ViewModels
{
    public class MenuViewModel : BaseViewModel<Category>
    {
        public ObservableCollection<Category> Categories { get; set; }
        public Command LoadItemsCommand { get; set; }
        public CategoryStore DataStore;

        public MenuViewModel()
        {
            Categories = new ObservableCollection<Category>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            DataStore = new CategoryStore(new ApiService(new HttpClient()));
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Categories.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Categories.Add(item);
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