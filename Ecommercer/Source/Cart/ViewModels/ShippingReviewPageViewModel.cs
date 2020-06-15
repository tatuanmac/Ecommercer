using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Ecommercer.Source.Cart.Model;
using Ecommercer.Source.Common.Bases;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Cart.ViewModels
{
    public class ShippingReviewPageViewModel : ViewModelBase
    {

        PaymentButton currentButton;

        public PaymenEnum PaymenEnum { get; set; }

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
                Title = "Review & Purchase",
                IsSelected = false
            }
        };

        public int positionView { get; set; }

        //Personal detail
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        //SHIPPING DETAILS
        public string Country { get; set; }
        public string Address { get; set; }
        public string ZIPCode { get; set; }
        public string City { get; set; }

        public ShippingReviewPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            positionView = 0;
        }

        ShippingAddressModel Model;

        Command SaveAndShip;
        public Command SaveCommand => SaveAndShip = SaveAndShip ?? new Command(SaveAndShipHere);

        private void SaveAndShipHere(object obj)
        {
            if (string.IsNullOrEmpty(FirstName) || string.IsNullOrEmpty(LastName) || string.IsNullOrEmpty(EmailAddress) || string.IsNullOrEmpty(PhoneNumber)
                || string.IsNullOrEmpty(Address) || string.IsNullOrEmpty(City) || string.IsNullOrEmpty(Country) || string.IsNullOrEmpty(ZIPCode))
            {

            }
            else
            {
                Model = new ShippingAddressModel()
                {
                    User = new Authentication.Model.UserModel
                    {
                        User_fullname = FirstName + LastName,
                        User_email = EmailAddress,
                        User_phone_number = PhoneNumber
                    },
                    Shipping_address = Address,
                    Shipping_city = City,
                    Shipping_country = Country,
                    Shipping_zipcode = ZIPCode
                };

                foreach (var item in ToolbarItem)
                {
                    if (item != obj)
                    {
                        item.IsSelected = false;
                    }
                }
                positionView = 1;
                ToolbarItem[positionView].IsSelected = true;
            }


        }

        Command<PaymentButton> Enum;
        public Command<PaymentButton> EnumCommand => Enum = Enum ?? new Command<PaymentButton>(EnumTap);

        private void EnumTap(PaymentButton obj)
        {
            currentButton = obj;
            currentButton.IsSelected = true;
            foreach (var item in ToolbarItem)
            {
                if (item != currentButton)
                {
                    item.IsSelected = false;

                }
                if (item.Type == PaymenEnum.Personal_shipping_detail && obj.Type == PaymenEnum.Personal_shipping_detail)
                {
                    item.IsSelected = true;
                }
                else
                {
                    item.IsSelected = false;
                }
            }
            if (ToolbarItem[0].IsSelected == true) {
                obj.IsSelected = true;
            }
            else
            {
                obj.IsSelected = true;
            }
            if (obj.Type == PaymenEnum.Personal_shipping_detail)
            {
                FirstName = "";
                LastName = "";
                EmailAddress = "";
                PhoneNumber = "";

                Country = "";
                Address = "";
                ZIPCode = "";
                City = "";
                obj.IsSelected = true;
                positionView = 0;
            }
            else
            {
                obj.IsSelected = false;
                ToolbarItem[0].IsSelected = true;
            }
        }
    }
}
