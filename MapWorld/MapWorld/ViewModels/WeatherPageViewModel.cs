using MapWorld.Navigation;
using MapWorld.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MapWorld.ViewModels
{
    internal class WeatherPageViewModel
    {
        public Command NavigateToNextPageCommand { get; set; }
        public Command NavigateToNextPageCommand2 { get; set; }
        public Command NavigateToNextPageCommand3 { get; set; }



        public void NavigateToNextPage()
        {
            var newpage = new HomePage();
            NavigationDispatcher.Instance.Navigation.PushAsync(newpage);
        }

        public void NavigateToNextPage2()
        {
            var newpage = new SatellitePage();
            NavigationDispatcher.Instance.Navigation.PushAsync(newpage);
        }

        public void NavigateToNextPage3()
        {
            var newpage = new TrafficPage();
            NavigationDispatcher.Instance.Navigation.PushAsync(newpage);
        }
        public WeatherPageViewModel()
        {
            NavigateToNextPageCommand = new Command(NavigateToNextPage);
            NavigateToNextPageCommand2 = new Command(NavigateToNextPage2);
            NavigateToNextPageCommand3 = new Command(NavigateToNextPage3);
        }
    }
}
