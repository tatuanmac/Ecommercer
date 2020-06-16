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
        public static readonly BindableProperty TextChangedProperty =
            BindableProperty.Create(nameof(TextChange), typeof(ICommand), typeof(SearchNavigationBar), null);
        public ICommand TextChange
        {
            get { return (ICommand)GetValue(TextChangedProperty); }
            set { SetValue(TextChangedProperty, value); }
        }
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
            var gestureRecognizer = new TapGestureRecognizer();
            gestureRecognizer.Tapped += (sender, e) => FilterCommand?.Execute(sender);
            filter.GestureRecognizers.Add(gestureRecognizer);
            //
            var backGR = new TapGestureRecognizer();
            backGR.Tapped += (sender, e) => BackCommand?.Execute(sender);
            back.GestureRecognizers.Add(backGR);
            //
            var searchGR = new TapGestureRecognizer();
            //  searchGR.Tapped += (sender, e) => TextChange?.Execute(sender);
            searchBar.GestureRecognizers.Add(searchGR);


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
            //TextChange.Execute(sender);
            SearchCommand.Execute(sender);
        }
    }
}