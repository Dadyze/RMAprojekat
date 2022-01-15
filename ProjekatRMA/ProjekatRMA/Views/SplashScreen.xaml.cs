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
    public partial class SplashScreen : ContentPage
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void RegisterBtn(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Login());

        }

        private void LoginBtn(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Register());

        }
    }
}