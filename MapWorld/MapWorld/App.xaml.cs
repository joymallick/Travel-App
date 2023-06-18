using MapWorld.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MapWorld.Navigation;
using MapWorld.ViewModels;


namespace MapWorld
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new StartPage()); ;
            NavigationDispatcher.Instance.Initialize(MainPage.Navigation);
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
