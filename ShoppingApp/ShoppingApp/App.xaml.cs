using System;
using System.Collections.Generic;
using Xamarin.Forms;
using ShoppingApp.Services;
using ShoppingApp.Views;
using System.Net.Http;

namespace ShoppingApp
{
    public partial class App : Application
    {
        public HttpClient HttpClient
        {
            get => httpClient;
            set { }
        }
        public DatabaseService Database
        {
            get => db;
            set { }
        }

        private HttpClient httpClient = new HttpClient();
        private DatabaseService db = new DatabaseService();

        public App()
        {
            InitializeComponent();
            DependencyService.Register<OffersStore>();
            DependencyService.Register<HttpClient>();
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
