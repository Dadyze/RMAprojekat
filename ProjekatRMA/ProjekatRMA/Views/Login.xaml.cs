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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginSubmitBtn(object sender, EventArgs e)
        {
            if (UserData.Users.Any(x => x.Name == username.Text && x.Password == pass.Text))
            {
                UserObj DTO = UserData.Users.SingleOrDefault(x => x.Name == username.Text && x.Password == pass.Text);
                Application.Current.MainPage.Navigation.PushAsync(new WeatherLocation(DTO));
            }
        }

        private void LoginBtnRediretRegister(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Register());
        }
    }
}