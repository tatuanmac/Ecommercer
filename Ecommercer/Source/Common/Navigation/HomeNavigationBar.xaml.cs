using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;

namespace Ecommercer.Source.Common.Navigation
{
    public partial class HomeNavigationBar : GradientColorStack
    {
        public static readonly BindableProperty CommandProperty =
               BindableProperty.Create(nameof(Command), typeof(ICommand), typeof(NavigationBar), null);
        public ICommand Command
        {
            get { return (ICommand)GetValue(CommandProperty); }
            set { SetValue(CommandProperty, value); }
        }

        public static readonly BindableProperty MenuCommandProperty =
            BindableProperty.Create(nameof(MenuCommand), typeof(ICommand), typeof(NavigationBar), null);
        public ICommand MenuCommand
        {
            get { return (ICommand)GetValue(MenuCommandProperty); }
            set { SetValue(MenuCommandProperty, value); }
        }

        public static readonly BindableProperty TitleViewProperty =
   BindableProperty.Create(nameof(TitleView), typeof(string), typeof(NavigationBar), string.Empty, BindingMode.TwoWay);

        public string TitleView
        {
            get { return (string)GetValue(TitleViewProperty); }
            set { SetValue(TitleViewProperty, value); }
        }

        public HomeNavigationBar()
        {
            InitializeComponent();
            var heightStatusBar = DependencyService.Get<IGetHeightStatusBar>().GetStatusBarHeight();
            var heightNavigation = DependencyService.Get<IGetHeightStatusBar>().GetNavigationHeight();
            double a = heightNavigation + heightStatusBar;

            gridNav.Margin = new Thickness(0, heightStatusBar, 0, 0);
            this.HeightRequest = a;

            var gestureRecognizer = new TapGestureRecognizer();
            gestureRecognizer.Tapped += (sender, e) => Command?.Execute(sender);
            search.GestureRecognizers.Add(gestureRecognizer);

            //GetureRecognizer Menu
            var menuGR = new TapGestureRecognizer();
            menuGR.Tapped += (sender, e) => MenuCommand?.Execute(sender);
            menu.GestureRecognizers.Add(menuGR);

            title.BindingContext = this;
        }

        private void TapGestureRecognizer_Tapped1(object sender, System.EventArgs e)
        {
            var img = sender as Image;
            img.Opacity = 0;
            img.FadeTo(1, 250);
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            var img = sender as Image;
            img.Opacity = 0;
            img.FadeTo(1, 250);
        }

    }
}
