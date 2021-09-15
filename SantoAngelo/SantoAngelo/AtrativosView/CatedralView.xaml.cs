using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Maps;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SantoAngelo.AtrativosView
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CatedralView : ContentPage
    {
        public CatedralView()
        {
            InitializeComponent();

            var mapa = new Map(MapSpan.FromCenterAndRadius(new Position(-28.3056311, -54.2608277), Distance.FromMeters(500)));
            mapa.MapType = MapType.Street;

            var catedralSantoAngelo = new Pin()
            {
                Position = new Position(-28.3054048, -54.2614465),
                Label = "Catedral Angelopolitana"
            };

            mapa.Pins.Add(catedralSantoAngelo);

            MapContainer.Children.Add(mapa);
        }
    }
}