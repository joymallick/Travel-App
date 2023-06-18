using MapWorld.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;

namespace MapWorld.Services
{
    public class MapsPin : BaseViewModel
	{
		


		public MapsPin()
		{

			PinCollection.Add(new Pin() { Position = MyPosition, Type = PinType.Generic, Label = "Here Is Rome" });
			PinCollection.Add(new Pin() { Position = MyPosition2, Type = PinType.Generic, Label = "Here Is Paris" });
			PinCollection.Add(new Pin() { Position = MyPosition3, Type = PinType.Generic, Label = "Here Is London" });


			Task.Run(async () =>
			{
				var position = await Plugin.Geolocator.CrossGeolocator.Current.GetPositionAsync();
				MyPosition = new Position(position.Latitude, position.Longitude);
				MyPosition2 = new Position(position.Latitude, position.Longitude);
				MyPosition3 = new Position(position.Latitude, position.Longitude);
			});
		}



		private ObservableCollection<Pin> _pinCollection = new ObservableCollection<Pin>();
		public ObservableCollection<Pin> PinCollection { 
			get { return _pinCollection; } 
			set { _pinCollection = value; OnPropertyChanged(nameof(value)); ; } }

		private Position _myPosition = new Position(41.89295098015189, 12.49985440783718);
		private Position _myPosition2 = new Position(48.855219469152495, 2.331239685120854);
		private Position _myPosition3 = new Position(51.515490772645435, -0.1359677239551905);

		public Position MyPosition { get { return _myPosition; } set { _myPosition = value; OnPropertyChanged(); } }
		public Position MyPosition2 { get { return _myPosition2; } set { _myPosition = value; OnPropertyChanged(); } }

		public Position MyPosition3 { get { return _myPosition3; } set { _myPosition = value; OnPropertyChanged(); } }

	}
}
