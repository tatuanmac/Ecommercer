using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Ecommercer.Source.Common.Bases;
using Ecommercer.Source.Home.Model;
using Ecommercer.Source.Home.Service;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Home.ViewModels
{
    public class SearchViewModel : ViewModelBase
    {
        readonly IStore service;

        public string TextResult { set; get; }

        public ObservableCollection<ProductModel> ListProduct { get; set; }


        public SearchViewModel(INavigationService navigationService, IStore service) : base(navigationService)
        {
            this.service = service;
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
        ICommand TextChangeCmd;
        public ICommand TextChangeCommand => TextChangeCmd = TextChangeCmd ?? new Command(SearchProduct);

        private  async void SearchProduct()
        {
            var datas = await service.ListProduct();
            if (datas == null)
            {
                return;
            }

            if (TextResult != null)
            {
                var listData=datas.Where(i => i.Product_name.ToLower().Contains(TextResult.ToLower())).ToList();
                ListProduct = new ObservableCollection<ProductModel>(listData);
            }
        }
    }
}
