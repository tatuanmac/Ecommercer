using System;
using System.Collections.ObjectModel;
using Ecommercer.Source.Common.Bases;
using Ecommercer.Source.Profile.Model;
using Ecommercer.Source.Profile.Service;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Profile.ViewModels
{
    public class ProfileViewModel : TabbedViewModelBase
    {
        public ProfileModel StoreDetail { get; set; }

        IProfile service;

        public ProfileViewModel(INavigationService navigationService, IProfile service) : base(navigationService)
        {
            this.service = service;
        }

        public override async void TabActiveChanged()
        {
            if (IsActive)
            {
                var storeData = await service.GetProfileDetail();
                if (storeData == null)
                {
                    return;
                }
                StoreDetail = storeData;
                var a = StoreDetail.store.ProductItem[1].Product_name;
            }
        }

        Command<ProfileModel> EditProfile;
        public Command<ProfileModel> EditProfileCommand => EditProfile = EditProfile ?? new Command<ProfileModel>(EditUserProfile);

        private void EditUserProfile(ProfileModel obj)
        {
            throw new NotImplementedException();
        }

        Command<ProfileModel> ItemDetail;
        public Command<ProfileModel> ItemDetailCommand => ItemDetail = ItemDetail ?? new Command<ProfileModel>(ItemsDetail);

        private void ItemsDetail(ProfileModel obj)
        {
            NavigationService.NavigateAsync(Routes.ProductDetail);
        }

    }
}
