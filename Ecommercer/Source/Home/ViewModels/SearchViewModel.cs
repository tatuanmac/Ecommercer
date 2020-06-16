using System;
using System.Diagnostics;
using Ecommercer.Source.Common.Bases;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Home.ViewModels
{
    public class SearchViewModel : ViewModelBase
    {

        public  string TextResult { set; get; }

        public SearchViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        Command FilterCmd;
        public Command FilterCommand => FilterCmd = FilterCmd ?? new Command(FilterProduct);

        private void FilterProduct()
        {

        }

        Command BackCmd;
        public Command BackCommand => BackCmd = BackCmd ?? new Command(BackToPreviousPage);

        private void BackToPreviousPage()
        {
            NavigationService.GoBackAsync();
        }
        //text change search bar
        Command TextChangeCmd;
        public Command TextChangeCommand => TextChangeCmd = TextChangeCmd ?? new Command(SearchProduct);

        private void SearchProduct()
        {
            Debug.WriteLine(TextResult);
        }
    }
}
