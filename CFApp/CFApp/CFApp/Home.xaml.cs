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
                             new Position(-23.4859591, -47.4420192),
                             Distance.FromMiles(0.5)));

            var pin = new Pin
            {
                Type = PinType.Place,
                Position = new Position(-23.4859591, -47.4420192),
                Label = "Demo Maps",
                Address = "www.julianocustodio.com",
            };

            Mapa.Pins.Add(pin);
        }
	}
}