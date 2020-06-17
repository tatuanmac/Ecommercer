using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ecommercer.Source.Common.Navigation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SearchNavigationBar : GradientColorStack
    {
        public static readonly BindableProperty FilterCommandProperty =
             BindableProperty.Create(nameof(FilterCommand), typeof(ICommand), typeof(SearchNavigationBar), null);
        public ICommand FilterCommand
        {
            get { return (ICommand)GetValue(FilterCommandProperty); }
            set { SetValue(FilterCommandProperty, value); }
        }
        //Back
        public static readonly BindableProperty BackCommandProperty =
             BindableProperty.Create(nameof(BackCommand), typeof(ICommand), typeof(SearchNavigationBar), null);
        public ICommand BackCommand
        {
            get { return (ICommand)GetValue(BackCommandProperty); }
            set { SetValue(BackCommandProperty, value); }
        }
        //Search
        public static readonly BindableProperty SearchCommandProperty =
            BindableProperty.Create(nameof(SearchCommand), typeof(ICommand), typeof(SearchNavigationBar), null);
        public ICommand SearchCommand
        {
            get { return (ICommand)GetValue(SearchCommandProperty); }
            set { SetValue(SearchCommandProperty, value); }
        }

        public static readonly BindableProperty TextSearchProperty =
            BindableProperty.Create(nameof(TextSearch), typeof(string), typeof(SearchNavigationBar), string.Empty);
        public string TextSearch
        {
            get { return (string)GetValue(TextSearchProperty); }
            set { SetValue(TextSearchProperty, value); }
        }

        
        public SearchNavigationBar()
        {
            InitializeComponent();
            var heightStatusBar = DependencyService.Get<IGetHeightStatusBar>().GetStatusBarHeight();
            var heightNavigation = DependencyService.Get<IGetHeightStatusBar>().GetNavigationHeight();
            double a = heightNavigation + heightStatusBar;

            gridNav.Margin = new Thickness(0, heightStatusBar, 0, 0);
            this.HeightRequest = a;
            //
            var gestureRecognizer = new TapGestureRecognizer();
            gestureRecognizer.Tapped += (sender, e) => FilterCommand?.Execute(sender);
            filter.GestureRecognizers.Add(gestureRecognizer);
            //
            var backGR = new TapGestureRecognizer();
            backGR.Tapped += (sender, e) => BackCommand?.Execute(sender);
            back.GestureRecognizers.Add(backGR);
            //
            var searchGR = new TapGestureRecognizer();
            searchBar.GestureRecognizers.Add(searchGR);
            searchBar.BindingContext = this;

        }

        private void TapGestureRecognizer_Tapped(object sender, System.EventArgs e)
        {
            var img = sender as Image;
            img.Opacity = 0;
            img.FadeTo(1, 250);
        }

        private void TapGestureRecognizer_Tapped_1(System.Object sender, System.EventArgs e)
        {
            var img = sender as Image;
            img.Opacity = 0;
            img.FadeTo(1, 250);
        }

        void SearchBar_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            SearchCommand?.Execute(sender);
           
        }
    }
}