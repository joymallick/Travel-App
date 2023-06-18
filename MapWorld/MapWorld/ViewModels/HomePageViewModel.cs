using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Maps;


namespace MapWorld.ViewModels
{    /* Tried to run this code to add or remove pins but was not successful*/
    public class BindableMap : Map
    {
        public static readonly BindableProperty MapPinsProperty = BindableProperty.Create(
                 nameof(Pins),
                 typeof(ObservableCollection<Pin>),
                 typeof(BindableMap),
                 new ObservableCollection<Pin>(),
                 propertyChanged: (b, o, n) =>
                 {
                     var bindable = (BindableMap)b;
                     bindable.Pins.Clear();

                     var collection = (ObservableCollection<Pin>)n;
                     foreach (var item in collection)
                         bindable.Pins.Add(item);
                     collection.CollectionChanged += (sender, e) =>
                     {


                         {

                             if (e.NewItems != null)
                                 foreach (var item in e.NewItems)
                                     bindable.Pins.Add((Pin)item);





                         }

                     };
                 });




        public IList<Pin> MapPins { get; set; }

    }
    
}

