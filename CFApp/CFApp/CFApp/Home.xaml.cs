using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CFApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Home : ContentPage
	{
		public Home ()
		{
			InitializeComponent ();

            Mapa.MoveToRegion(MapSpan.FromCenterAndRadius(
                            new Position(-23.4859591, -54.610099),
                             Distance.FromMiles(10)));

            var pin = new Pin
            {
               Type = PinType.SearchResult,
               Position = new Position(-20.443668, -54.6177232),
              Label = "UBS",
               Address = "26 DE AGOSTO",
            };

            var pin1 = new Pin
            {
                Type = PinType.SearchResult,
                Position = new Position(-20.431316, -54.599433),
                Label = "UBS",
                Address = "Coronel Antonino",
            };

            var pin2 = new Pin
            {
                Type = PinType.SearchResult,
                Position = new Position(-20.410378, -54.572102),
                Label = "UBS",
                Address = "Nova Bahia",
            };

            var pin3 = new Pin
            {
                Type = PinType.SearchResult,
                Position = new Position(-20.475270, -54.621885),
                Label = "UBS",
                Address = "Vila Carvalho",
            };

            Mapa.Pins.Add(pin);
            Mapa.Pins.Add(pin1);
            Mapa.Pins.Add(pin2);
            Mapa.Pins.Add(pin3);
        }
	}
}