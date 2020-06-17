using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Ecommercer.Source.Cart.Model;
using Ecommercer.Source.Cart.Service;
using Ecommercer.Source.Common.Bases;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Cart.ViewModels
{
    public class CartViewModel : TabbedViewModelBase
    {
        ICart service;

        CartButton current;

        public CartEnum CartEnum { get; set; } = CartEnum.Current_Order;

        public List<CartButton> ToolbarTitle { get; set; } = new List<CartButton>
        {
            new CartButton
            {
                 Title = "Current Order",
                 Type = CartEnum.Current_Order,
                 IsSelected = true
            },
            new CartButton
            {
                 Title = "Pending Orders",
                 Type = CartEnum.Pending_Orders

            },
            new CartButton
            {
                 Title = "History",
                 Type = CartEnum.History
            }

        };

        public ObservableCollection<CartModel> ListCartItem { get; set; }

        public CartViewModel(INavigationService navigationService, ICart service) : base(navigationService)
        {
            this.service = service;
        }

        public override void TabActiveChanged()
        {

            _ = GetData();
        }

        async Task GetData()
        {
            var cartData = await service.GetListItemCart();
            if (cartData == null)
            {
                return;
            }

            ListCartItem = new ObservableCollection<CartModel>(cartData);
        }

        Command<CartButton> Enum;
        public Command<CartButton> EnumCommand => Enum = Enum ?? new Command<CartButton>(TypeCart);

        private async void TypeCart(CartButton obj)
        {
            if (current != null)
            {
                current.IsSelected = false;
            }
            current = obj;
            current.IsSelected = true;
            foreach (var item in ToolbarTitle)
            {
                if (item != obj)
                {
                    item.IsSelected = false;
                }
            }
            if (obj.Type == CartEnum.Pending_Orders)
            {
                await NavigationService.NavigateAsync(Routes.ShippingReview);
            }
        }

        Command Quantily;
        public Command QuantilyCommand => Quantily = Quantily ?? new Command(QuantilyChange);

        private void QuantilyChange()
        {

        }
    }
}
