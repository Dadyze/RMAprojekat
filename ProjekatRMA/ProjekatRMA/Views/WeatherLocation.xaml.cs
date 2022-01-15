using ProjekatRMA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProjekatRMA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherLocation : ContentPage
    {
        public UserObj LoggedUser { get; set; }
        public WeatherLocation(UserObj dTO)
        {
            LoggedUser = dTO;
            BindingContext = this;
            InitializeComponent();
        }

        private void SubmitLocation(object sender, EventArgs e)
        {
            string location = loc.Text;
            Application.Current.MainPage.Navigation.PushAsync(new CurrentWeatherPage(location, LoggedUser));
        }
    }
}