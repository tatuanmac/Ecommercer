using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecommercer.Source.Cart.Views;
using Ecommercer.Source.Deals.Views;
using Ecommercer.Source.Profile.Views;
using Ecommercer.Source.Tags.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ecommercer.Source.Home.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EcoTabbedPage : TabbedPage
    {
        public EcoTabbedPage()
        {
            InitializeComponent();
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            switch (CurrentPage)
            {
                case HomePage homepage:
                    Title = "Home";
                    break;
                case DealsPage dealsPage:
                    Title = "Deals";
                    break;
                case CartPage cart:
                    Title = "Cart";
                    break;
                case TagsPage tag:
                    Title = "Tags";
                    break;
                case ProfilePage profile:
                    Title = "Profile";
                    break;
            }
        }
    }
}
