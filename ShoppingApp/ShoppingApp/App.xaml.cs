using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ShoppingApp.Services;
using ShoppingApp.Views;
using System.Net.Http;
using Newtonsoft.Json;
using ShoppingApp.Models;

namespace ShoppingApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<OffersStore>();
            MainPage = new MainPage();
        }

        protected async override void OnStart()
        {

        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
