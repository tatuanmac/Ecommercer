using System;
using Xamarin.Forms;

namespace Ecommercer.Source.Deals.Navigation
{
    public class NavigationPageGradientHeader : NavigationPage
    {
        public NavigationPageGradientHeader(Page root) : base(root)
        {
        }

        public static readonly BindableProperty RightColorProperty =
          BindableProperty.Create(propertyName: nameof(RightColor),
              returnType: typeof(Color),
              declaringType: typeof(NavigationPageGradientHeader),
              defaultValue: Color.FromHex("#109F8D"));

        public static readonly BindableProperty LeftColorProperty =
           BindableProperty.Create(propertyName: nameof(LeftColor),
               returnType: typeof(Color),
               declaringType: typeof(NavigationPageGradientHeader),
               defaultValue: Color.FromHex("#36ED81"));

        public Color RightColor
        {
            get { return (Color)GetValue(RightColorProperty); }
            set { SetValue(RightColorProperty, value); }
        }

        public Color LeftColor
        {
            get { return (Color)GetValue(LeftColorProperty); }
            set { SetValue(LeftColorProperty, value); }
        }
    }
}
