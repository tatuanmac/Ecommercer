using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Ecommercer.Source.Cart.Views
{
    public partial class ShippingReviewPage : ContentPage
    {
        public ShippingReviewPage()
        {
            InitializeComponent();

        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            if (BindingContext != null)
            {
                Init();
            }
        }

        void Init()
        {
            var paymentPage = new PaymentMethodPage();
            paymentPage.BindingContext = BindingContext;

            var shipping = new PersonalandShippingDetailsPage();
            shipping.BindingContext = BindingContext;

            //paymentPage.SetBinding(BindingContextProperty, new Binding {
            //    Source = this,
            //    Path = nameof(BindingContext)
            //});
            //shipping.SetBinding(BindingContextProperty, new Binding
            //{
            //    Source = this,
            //    Path = nameof(BindingContext)
            //});

            var lst = new List<View> {
                shipping,paymentPage
            };

            csView.ItemsSource = lst;
        }
    }
}
