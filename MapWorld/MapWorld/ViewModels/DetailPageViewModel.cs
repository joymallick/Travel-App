using MapWorld.Navigation;
using MapWorld.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace MapWorld.ViewModels
{
	public class DetailPageViewModel 
	{
        public Command NavigateToNextPageCommand { get; set; }

        public void NavigateToNextPage()
        {
            var newpage = new HomePage();
            NavigationDispatcher.Instance.Navigation.PushAsync(newpage);
        }
       


        public DetailPageViewModel()
		{
            NavigateToNextPageCommand = new Command(NavigateToNextPage);

        }



		

	}
}
