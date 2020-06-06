using System;
using System.Windows.Input;
using ShoppingApp.Models;

using Xamarin.Forms;

namespace ShoppingApp.ViewModels
{
    public class AboutViewModel : BaseViewModel<Offer>
    {
        public AboutViewModel()
        {
            Title = "About";

            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
        }

        public ICommand OpenWebCommand { get; }
    }
}