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
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private void RegisterBtn(object sender, EventArgs e)
        {
            DisplayAlert("Msg", "User Created Successfully", "ok");
            UserData.Users.Add(new UserObj(username.Text, pass.Text));
            Application.Current.MainPage.Navigation.PushAsync(new Login());
        }

        private void RegisterBtnRediretLogin(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Login());
        }
    }
}