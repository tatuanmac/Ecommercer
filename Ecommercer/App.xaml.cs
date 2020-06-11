using System;
using System.Globalization;
using Ecommercer.Source.Authentication.ViewModels;
using Ecommercer.Source.Authentication.Views;
using Ecommercer.Source.Cart.Service;
using Ecommercer.Source.Cart.ViewModels;
using Ecommercer.Source.Cart.Views;
using Ecommercer.Source.Deals.Service;
using Ecommercer.Source.Deals.ViewModels;
using Ecommercer.Source.Deals.Views;
using Ecommercer.Source.Home.Service;
using Ecommercer.Source.Home.ViewModels;
using Ecommercer.Source.Home.Views;
using Ecommercer.Source.Profile.Service;
using Ecommercer.Source.Profile.ViewModels;
using Ecommercer.Source.Profile.Views;
using Ecommercer.Source.Tags.ViewModels;
using Ecommercer.Source.Tags.Views;
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
            
            var result = await NavigationService.NavigateAsync(Routes.EcoTabbed);
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
            containerRegistry.RegisterForNavigation<LoginPage, LoginViewModel>();
            containerRegistry.RegisterForNavigation<EcoTabbedPage>();
            containerRegistry.RegisterForNavigation<HomePage, HomeViewModel>();
            containerRegistry.RegisterForNavigation<DealsPage, DealsViewModel>();
            containerRegistry.RegisterForNavigation<CartPage, CartViewModel>();
            containerRegistry.RegisterForNavigation<TagsPage, TagsViewModel>();
            containerRegistry.RegisterForNavigation<ProfilePage, ProfileViewModel>();
        }

        private void RegisterService(IContainerRegistry containerRegistry)
        {
            containerRegistry.Register<IStore, StoreData>();
            containerRegistry.Register<IProfile, ProfileData>();
            containerRegistry.Register<IDeal, DealsData>();
            containerRegistry.Register<ICart, CartData>();
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
        public static readonly Uri LoginSignUp = new Uri($"/{navigation}/{nameof(LoginSignUpPage)}", UriKind.Relative);
        public static readonly Uri Login = new Uri($"{nameof(LoginPage)}", UriKind.Relative);
        public static readonly Uri EcoTabbed = new Uri($"/{navigation}/{nameof(EcoTabbedPage)}", UriKind.Absolute);
    }
}
