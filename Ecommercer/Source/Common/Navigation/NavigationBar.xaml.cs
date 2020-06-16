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
        public static readonly BindableProperty TitleViewProperty =
   BindableProperty.Create(nameof(TitleView), typeof(string), typeof(NavigationBar), string.Empty, BindingMode.TwoWay);
        public string TitleView
        {
            get { return (string)GetValue(TitleViewProperty); }
            set { SetValue(TitleViewProperty, value); }
        }

        public NavigationBar()
        {
            InitializeComponent();
            var gestureRecognizer = new TapGestureRecognizer();
            gestureRecognizer.Tapped += (sender, e) => Command?.Execute(sender);
         //   search.GestureRecognizers.Add(gestureRecognizer);
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
