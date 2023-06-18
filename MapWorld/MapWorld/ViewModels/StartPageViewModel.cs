using MapWorld.Navigation;
using MapWorld.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using MapWorld.Services;


namespace MapWorld.ViewModels


{
    public class StartPageViewModel : BaseViewModel
    {
        

        private ObservableCollection<Countries> Countries;


     
        public ObservableCollection<Countries> countries
        {
            get { return Countries; }
            set
            {
                Countries = value;
                OnPropertyChanged(nameof(countries));
            }
        }




        public StartPageViewModel()
        {
            countries = new ObservableCollection<Countries>();
            addData();
            NavigateToNextPageCommand = new Command(NavigateToNextPage);
            NavigateToNextPageCommand2 = new Command(NavigateToNextPage2);





        }

        private void addData()
        {
            countries.Add(new Countries
            {
                id = 0,
                
                country = "Italy",
                img = "Italy.jpg",

                capital= "Rome"
            });
            countries.Add(new Countries
            {
                id = 0,
               
                country = "England",
                img = "England.jpg",

                capital= "London"
            });
            countries.Add(new Countries
            {
                id = 0,
                
                country = "France",
                img = "France.jpg",
                capital = "Paris"
            });


        }
        public Command NavigateToNextPageCommand { get; set; }
        public Command NavigateToNextPageCommand2 { get; set; }

        public void NavigateToNextPage()
        {
            var newpage = new WeatherPage();
            NavigationDispatcher.Instance.Navigation.PushAsync(newpage);
            
        }

        public void NavigateToNextPage2()
        {
            var newpage2 = new DetailPage();
            NavigationDispatcher.Instance.Navigation.PushAsync(newpage2);
        }
      
        

    }
}
