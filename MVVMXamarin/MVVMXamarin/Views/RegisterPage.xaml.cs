using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVVMXamarin.Services;
using MVVMXamarin.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVMXamarin.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = new RegisterViewModel(new AlertService(), new NavigationService());
        }

    }
}