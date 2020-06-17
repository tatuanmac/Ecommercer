using System;
using Ecommercer.Source.Common.Bases;
using Ecommercer.Source.Profile.Model;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Home.ViewModels
{
    public class StoreDetailViewModel : ViewModelBase
    {
        public StoreDetailViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        Command ClosePage;
        public Command CloseCommand => ClosePage = ClosePage ?? new Command(Close);

        private void Close()
        {
            NavigationService.GoBackAsync();
        }

        Command BackCmd;
        public Command BackCommand => BackCmd = BackCmd ?? new Command(BackToPreviousPage);

        private void BackToPreviousPage()
        {
            NavigationService.GoBackAsync();
        }

        Command<ProfileModel> ItemDetail;
        public Command<ProfileModel> ItemDetailCommand => ItemDetail = ItemDetail ?? new Command<ProfileModel>(ItemsDetail);

        private void ItemsDetail(ProfileModel obj)
        {
            NavigationService.NavigateAsync(Routes.ProductDetail);
        }
    }

}
