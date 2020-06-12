using System;
using System.Collections.Generic;
using Ecommercer.Source.Cart.Model;
using Ecommercer.Source.Cart.Service;
using Ecommercer.Source.Common.Bases;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Cart.ViewModels
{
    public class PersonalandShippingDetailsViewModel : ViewModelBase
    {
        ICart service;

        
        public PersonalandShippingDetailsViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        
        Command SaveAndShip;
        public Command SaveCommand => SaveAndShip = SaveAndShip ?? new Command(SaveAndShipHere);

        private void SaveAndShipHere(object obj)
        {

        }
    }
}
