using System;
using Ecommercer.Source.Common.Bases;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Home.ViewModels
{
    public class StoreDetailViewModel : ViewModelBase
    {
        public StoreDetailViewModel(INavigationService navigationService) : base (navigationService)
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
    }
}
