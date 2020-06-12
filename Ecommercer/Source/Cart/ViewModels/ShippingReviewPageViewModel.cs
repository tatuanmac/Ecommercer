using System;
using System.Collections.Generic;
using Ecommercer.Source.Cart.Model;
using Ecommercer.Source.Common.Bases;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Cart.ViewModels
{
    public class ShippingReviewPageViewModel : ViewModelBase
    {
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

        public int positionView { get; set; }

        public ShippingReviewPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            positionView = 0;
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
            if (obj.Type == PaymenEnum.Personal_shipping_detail)
            {
                positionView = 0;
            }
            else
            {
                positionView = 1;
            }
        }
    }
}
