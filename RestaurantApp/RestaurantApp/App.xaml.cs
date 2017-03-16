using FreshMvvm;
using RestaurantApp.PageModels;
using RestaurantApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace RestaurantApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            FreshIOC.Container.Register<IApiService, ApiService>();

            var tabContainer = new FreshTabbedNavigationContainer();

            tabContainer.AddTab<ContactPageModel>("Contact", "");
            tabContainer.AddTab<GalleryPageModel>("Gallery", "");
            tabContainer.AddTab<MapPageModel>("Map", "");
            tabContainer.AddTab<MenuPageModel>("Menu", "");
            tabContainer.AddTab<SpecialOffersPageModel>("Special Offers", "");

            MainPage = tabContainer;
        }

        protected override void OnStart()
        {
            // Handle when your app starts
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
