using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ecommercer.Source.Common.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class NavigationBar : GradientColorStack
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
        //Back
        public static readonly BindableProperty BackCommandProperty =
             BindableProperty.Create(nameof(BackCommand), typeof(ICommand), typeof(SearchNavigationBar), null);
        public ICommand BackCommand
        {
            get { return (ICommand)GetValue(BackCommandProperty); }
            set { SetValue(BackCommandProperty, value); }
        }
        public NavigationBar()
        {
            InitializeComponent();
            //
            var heightStatusBar = DependencyService.Get<IGetHeightStatusBar>().GetStatusBarHeight();
            var heightNavigation = DependencyService.Get<IGetHeightStatusBar>().GetNavigationHeight();
            double a = heightNavigation + heightStatusBar;

            gridNav.Margin = new Thickness(0, heightStatusBar, 0, 0);
            this.HeightRequest = a;
            //
            var backGR = new TapGestureRecognizer();
            backGR.Tapped += (sender, e) => BackCommand?.Execute(sender);
            back.GestureRecognizers.Add(backGR);

            title.BindingContext = this;
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            var img = sender as Image;
            img.Opacity = 0;
            img.FadeTo(1, 250);
        }

    }
}
