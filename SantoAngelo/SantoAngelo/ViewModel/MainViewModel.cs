using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SantoAngelo.ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public Command OpenCatedralView { get; set; }
        public Command OpenMuseuMunicipalView { get; set; }
        public Command OpenMemorialPrestesView { get; set; }
        public Command OpenMuseuCinemaView { get; set; }
        public INavigation Navigation { get; set; }

        public MainViewModel()
        {

        }

        public MainViewModel(INavigation navigation)
        {
            this.Navigation = navigation;
            OpenCatedralView = new Command(async () => await ShowCatedralView());
            OpenMuseuCinemaView = new Command(async () => await ShowMuseuCinemaView());
        }

        private async Task ShowCatedralView()
        {
            await Navigation.PushAsync(new AtrativosView.CatedralView());
        }

        private async Task ShowMuseuCinemaView()
        {
            await Navigation.PushAsync(new AtrativosView.MuseuDoCinemaView());
        }
    }
}
