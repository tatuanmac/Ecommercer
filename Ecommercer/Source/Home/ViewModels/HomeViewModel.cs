using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Ecommercer.Source.Common.Bases;
using Ecommercer.Source.Home.Model;
using Ecommercer.Source.Home.Service;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Home.ViewModels
{

    public class HomeViewModel : TabbedViewModelBase
    {
        HomeButton currentFilter;
        public HomeEnum HomeEnum { get; set; } = HomeEnum.MostPopular;

        public List<HomeButton> ToolbarTitle { set; get; } = new List<HomeButton> {
            new HomeButton {

                Title="Most Popular",
                Type = HomeEnum.MostPopular,
                IsSelected = true
            },
            new HomeButton {

                Title="Featured",
                Type = HomeEnum.Featured
            },
            new HomeButton {

                Title="Top Sellers",
                Type = HomeEnum.TopSellers
            },
            new HomeButton {

                Title="Following",
                Type = HomeEnum.Following
            }
        };

        IStore service;

        public ObservableCollection<StoreModel> ListStores { get; set; }

        public HomeViewModel(INavigationService navigationService, IStore service) : base(navigationService)
        {
            this.service = service;
        }

        public override async void TabActiveChanged()
        {
            if (IsActive)
            {
                var datas = await service.ListStore();
                if (datas == null)
                {
                    return;
                }
                ListStores = new ObservableCollection<StoreModel>(datas);
            }
        }

        Command<HomeButton> Enum;
        public Command<HomeButton> EnumCommand => Enum = Enum ?? new Command<HomeButton>(TypeHome);

        private void TypeHome(HomeButton obj)
        {
            if (currentFilter != null)
            {
                currentFilter.IsSelected = false;
            }
            currentFilter = obj;
            currentFilter.IsSelected = true;
            foreach (var item in ToolbarTitle)
            {
                if (item != obj)
                {
                    item.IsSelected = false;
                }
            }
        }

        Command Follow;
        public Command FollowCommand => Follow = Follow ?? new Command(FollowStore);

        private void FollowStore()
        {

        }

        Command StoreDetail;
        public Command StoreDetailCommand => StoreDetail = StoreDetail ?? new Command(StoreDetailStore);

        private void StoreDetailStore()
        {

        }
    }
}
