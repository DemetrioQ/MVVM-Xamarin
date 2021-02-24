using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMXamarin
{
    public partial class LoginPage : ContentPage
    {
        private bool canClick = true;
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void LoginButton_Clicked(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(email.Text))
            {
                await Application.Current.MainPage.DisplayAlert("Error","El campo de email no puede de estar vacio", "Ok");
            }
            else if (string.IsNullOrEmpty(password.Text))
            {
                await Application.Current.MainPage.DisplayAlert("Error", "El campo de contraseña no puede de estar vacio", "Ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Bienvenido", "Hola, " + email.Text, "Ok");
                var homePage = new HomeTabbedPage();
                NavigationPage.SetHasNavigationBar(homePage, false);
                await Navigation.PushAsync(homePage);
            }
            
        }

        private async void RegisterButton_Clicked(object sender, EventArgs e)
        {

           await Navigation.PushAsync(new MVVMXamarin.RegisterPage());
           

        }
    }
}
