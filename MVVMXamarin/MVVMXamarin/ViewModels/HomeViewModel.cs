using MVVMXamarin.Models;
using MVVMXamarin.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace MVVMXamarin.ViewModels
{
    public class HomeViewModel : BaseViewModel
    {
        public MenuOption BarAndHotelsMenuOption { get; set; } = new MenuOption();
        public MenuOption FreeDinningMenuOption { get; set; } = new MenuOption();
        public MenuOption CafesMenuOption { get; set; } = new MenuOption();
        public MenuOption NearbyMenuOption { get; set; } = new MenuOption();
        public MenuOption FastFoodsMenuOption { get; set; } = new MenuOption(); 
        public MenuOption FeaturedFoodsMenuOption { get; set; } = new MenuOption();

        public HomeViewModel(IAlertService alertService, INavigationService navigationService) : base(alertService, navigationService)
        {
            BarAndHotelsMenuOption.Title = "Bars & Hotels";
            BarAndHotelsMenuOption.Image = "BarsIcon";

            FreeDinningMenuOption.Title = "Free Dinning";
            FreeDinningMenuOption.Image = "FreeDiningIcon";

            CafesMenuOption.Title = "Cafes";
            CafesMenuOption.Image = "CafeIcon";

            NearbyMenuOption.Title = "Nearby";
            NearbyMenuOption.Image = "NearbyIcon";

            FastFoodsMenuOption.Title = "Fast Foods";
            FastFoodsMenuOption.Image = "FastFoodIcon";

            FeaturedFoodsMenuOption.Title = "Featured Foods";
            FeaturedFoodsMenuOption.Image = "FeaturedFoodIcon";
        }


    }
}
