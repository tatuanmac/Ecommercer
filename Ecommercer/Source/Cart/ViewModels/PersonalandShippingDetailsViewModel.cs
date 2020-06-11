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

        PaymentButton currentButton;

        public PaymenEnum PaymenEnum { get; set; } = PaymenEnum.Personal_shipping_detail;

        public List<PaymentButton> ToolbarItem { get; set; } = new List<PaymentButton>
        {
            new PaymentButton
            {
                 Type = PaymenEnum.Personal_shipping_detail,
                 Title = "Personal & Shipping Details",
                 IsSelected = true
            },
            new PaymentButton
            {
                Type = PaymenEnum.Review_Purchase,
                Title = "Review & Purchase"
            }
        };

        public PersonalandShippingDetailsViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        Command<PaymentButton> Enum;
        public Command<PaymentButton> EnumCommand => Enum = Enum ?? new Command<PaymentButton>(EnumTap);

        private void EnumTap(PaymentButton obj)
        {

            if (currentButton != null)
            {
                currentButton.IsSelected = false;
            }
            currentButton = obj;
            currentButton.IsSelected = true;
            foreach (var item in ToolbarItem)
            {
                if (item != obj)
                {
                    item.IsSelected = false;
                }
            }
        }
        Command SaveAndShip;
        public Command SaveCommand => SaveAndShip = SaveAndShip ?? new Command(SaveAndShipHere);

        private void SaveAndShipHere(object obj)
        {

        }
    }
}
