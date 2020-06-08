﻿using System;
using System.Globalization;
using Ecommercer.Source.Authentication.ViewModels;
using Ecommercer.Source.Authentication.Views;
using Prism;
using Prism.DryIoc;
using Prism.Ioc;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Ecommercer
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer platformInitializer = null) : base(platformInitializer)
        {
            var culture = new CultureInfo("en-US");

            //Culture for any thread
            CultureInfo.DefaultThreadCurrentCulture = culture;

            //Culture for UI in any thread
            CultureInfo.DefaultThreadCurrentUICulture = culture;

            // AppResources.Culture = CrossMultilingual.Current.DeviceCultureInfo;

        }
        protected override async void OnInitialized()
        {
            InitializeComponent();

            VersionTracking.Track();

            var result = await NavigationService.NavigateAsync(Routes.LoginSignUp);
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            RegisterExternalService(containerRegistry);
            RegisterForNavigation(containerRegistry);
            RegisterService(containerRegistry);
            RegisterDialogs(containerRegistry);
        }

        private void RegisterForNavigation(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<LoginSignUpPage, LoginSignUpViewModel>();
        }

        private void RegisterService(IContainerRegistry containerRegistry)
        {
        }

        private void RegisterDialogs(IContainerRegistry containerRegistry)
        {
        }

        private void RegisterExternalService(IContainerRegistry containerRegistry)
        {
        }
    }
    public sealed partial class Routes
    {
        static readonly string navigation = nameof(NavigationPage);
        public static readonly Uri LoginSignUp = new Uri($"{nameof(LoginSignUpPage)}", UriKind.Relative);
    }
}
