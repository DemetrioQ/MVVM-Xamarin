using System;
using System.ComponentModel;
using MVVMXamarin.Services;

namespace MVVMXamarin.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        public IAlertService AlertService { get; }
        public INavigationService NavigationService { get; }

        protected BaseViewModel(IAlertService alertService, INavigationService navigationService)
        {
            AlertService = alertService;
            NavigationService = navigationService;
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}
