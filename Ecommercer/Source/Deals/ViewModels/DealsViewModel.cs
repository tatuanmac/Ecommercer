using System;
using System.Collections.Generic;
using Ecommercer.Source.Common.Bases;
using Ecommercer.Source.Deals.Model;
using Ecommercer.Source.Deals.Service;
using Ecommercer.Source.Home.Model;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Deals.ViewModels
{
    public class DealsViewModel : TabbedViewModelBase
    {
        DealButton current;
        public DealEnum DealEnum { get; set; } = DealEnum.Most_Popular;
        public List<DealButton> ToolbarTitle { get; set; } = new List<DealButton>
        {
            new DealButton
            {
                 Title = "Most Popular",
                 Type = DealEnum.Most_Popular,
                 IsSelected = true
            },
            new DealButton
            {
                Title = "Featured",
                Type = DealEnum.Featured
            },
            new DealButton
            {
                Title = "Deals of the month",
                Type = DealEnum.Deals_of_the_month
            }
        };

        IDeal service;

        public List<ProductModel> ListDealItems { get; set; }

        public DealsViewModel(INavigationService navigationService, IDeal service) : base(navigationService)
        {
            this.service = service;
        }

        public override async void TabActiveChanged()
        {
            if (IsActive)
            {
                var datas = await service.GetListMostPopular();
                if (datas == null)
                {
                    return;
                }
                ListDealItems = new List<ProductModel>(datas);
            }
        }

        Command<DealButton> Enum;
        public Command<DealButton> EnumCommand => Enum = Enum ?? new Command<DealButton>(TypeDeals);

        private void TypeDeals(DealButton obj)
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
        }

        Command Buy;
        public Command BuyCommand => Buy = Buy ?? new Command(BuyItemNow);

        private void BuyItemNow(object obj)
        {

        }
    }
}
