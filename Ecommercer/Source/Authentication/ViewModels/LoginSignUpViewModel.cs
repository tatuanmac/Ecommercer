﻿using System;
using Ecommercer.Source.Common.Bases;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Authentication.ViewModels
{
    public class LoginSignUpViewModel : ViewModelBase
    {

        public LoginSignUpViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        //Command
        Command FBCommand;
        public Command LoginFBCommand => FBCommand = FBCommand ?? new Command(LoginWithFacebook);

        private async void LoginWithFacebook()
        {
            var result = await NavigationService.NavigateAsync(Routes.EcoTabbed);
        }

        Command LoginCommand;
        public Command Login => LoginCommand = LoginCommand ?? new Command(UserLogin);

        private async void UserLogin()
        {
            var result = await NavigationService.NavigateAsync(Routes.Login);
        }

        Command SignUpCommand;
        public Command SignUp => SignUpCommand = SignUpCommand ?? new Command(UserSignUp);

        private void UserSignUp()
        {

        }
    }
}
