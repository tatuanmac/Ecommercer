using System;
using Ecommercer.Source.Common.Bases;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Authentication.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {

        public LoginViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        Command ForgotPass;
        public Command ForgotPassCommand => ForgotPass = ForgotPass ?? new Command(ForgotPassword);

        private void ForgotPassword()
        {

        }

        Command ClosePage;
        public Command CloseCommand => ClosePage = ClosePage ?? new Command(Close);

        private void Close()
        {
            NavigationService.GoBackAsync();
        }
    }
}
