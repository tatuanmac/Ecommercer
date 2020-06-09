using System;
using System.Collections;
using System.Collections.Generic;
using Ecommercer.Source.Common.Bases;
using Prism.Navigation;
using Xamarin.Forms;
using static Ecommercer.Source.Home.Model.HomeModel;

namespace Ecommercer.Source.Home.ViewModels
{
    public class HomeViewModel : ViewModelBase
    {
        public List<string> ToolbarTitle = new List<string>();


        public HomeViewModel(INavigationService navigationService) : base(navigationService)
        {
            ToolbarTitle.Add("Most Popular");
            ToolbarTitle.Add("Featured");
            ToolbarTitle.Add("Top Sellers");
            ToolbarTitle.Add("Following");
        }

        public HomeEnum HomeEnum { get; set; } = HomeEnum.MostPopular;

        Command<HomeEnum> Enum;
        public Command<HomeEnum> EnumCommand => Enum ?? Enum ?? new Command<HomeEnum>(TypeHome);

        private void TypeHome(HomeEnum obj)
        {
            HomeEnum = obj;
        }
    }
}
