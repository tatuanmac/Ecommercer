using System;
using Ecommercer.Source.Common.Bases;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Detail.ViewModels
{
    public class DetailProductViewModel : ViewModelBase
    {
        public DetailProductViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        Command BackCmd;
        public Command BackCommand => BackCmd = BackCmd ?? new Command(BackToPreviousPage);

        private void BackToPreviousPage()
        {
            NavigationService.GoBackAsync();
        }
    }
}
