using System;
using System.Windows.Input;
using MVVMXamarin.Services;
using Xamarin.Forms;

namespace MVVMXamarin.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public ICommand LoginCommand { get; }
        public ICommand RegisterCommand { get; }
        public string Email { get; set; }
        public string Password { get; set; }
        public LoginViewModel(IAlertService alertService, INavigationService navigationService) : base(alertService, navigationService)
        {
            LoginCommand = new Command(OnLogin);
            RegisterCommand = new Command(OnRegister);
        }

        private async void OnLogin()
        {
            if (string.IsNullOrEmpty(Email) || string.IsNullOrEmpty(Password))
            {
                await AlertService.AlertAsync("Error", "Hay campos vacios");
            }
            else
            {
                await AlertService.AlertAsync("Bienvenido", "Hola, " + Email);
                await NavigationService.NavigationAsync(new HomeTabbedPage(), false);
            }
        }

        private async void OnRegister()
        {
            await NavigationService.NavigationAsync(new MVVMXamarin.RegisterPage(), true);
        }
    }
}
