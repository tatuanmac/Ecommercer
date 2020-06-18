using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ecommercer.Source.Common.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChatNavigationBar : GradientColorStack
    {
        //menu
        public static readonly BindableProperty MenuCommandProperty =
            BindableProperty.Create(nameof(MenuCommand), typeof(ICommand), typeof(NavigationBar), null);
        public ICommand MenuCommand
        {
            get { return (ICommand)GetValue(MenuCommandProperty); }
            set { SetValue(MenuCommandProperty, value); }
        }
        //title
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

        public ChatNavigationBar()
        {
            InitializeComponent();
            var heightStatusBar = DependencyService.Get<IGetHeightStatusBar>().GetStatusBarHeight();
            var heightNavigation = DependencyService.Get<IGetHeightStatusBar>().GetNavigationHeight();

            gridNav.Margin = new Thickness(0, heightStatusBar, 0, 0);
            this.HeightRequest = heightNavigation + heightStatusBar;

            //
            var backGR = new TapGestureRecognizer();
            backGR.Tapped += (sender, e) => BackCommand?.Execute(sender);
            back.GestureRecognizers.Add(backGR);
            //
            var gestureRecognizer = new TapGestureRecognizer();
            gestureRecognizer.Tapped += (sender, e) => MenuCommand?.Execute(sender);
            menu.GestureRecognizers.Add(gestureRecognizer);
            //
            title.BindingContext = this;
        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            var img = sender as Image;
            img.Opacity = 0;
            img.FadeTo(1, 250);
        }
        private void TapGestureRecognizer_Tapped1(object sender, System.EventArgs e)
        {
            var img = sender as Image;
            img.Opacity = 0;
            img.FadeTo(1, 250);
        }
    }
}
