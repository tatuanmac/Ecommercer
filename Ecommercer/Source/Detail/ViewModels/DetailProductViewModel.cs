using System;
using System.Collections.ObjectModel;
using Ecommercer.Source.Common.Bases;
using Ecommercer.Source.Home.Model;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Detail.ViewModels
{
    public class DetailProductViewModel : ViewModelBase
    {

        public ObservableCollection<ColorProductModel> Colors { set; get; } = new ObservableCollection<ColorProductModel>()
        {
            new ColorProductModel()
            {
                 ColorProduct = "#1F1F1F",
                 IsColorSelected = true
            },

            new ColorProductModel()
            {
                 ColorProduct = "#EEEDE9"
            },

            new ColorProductModel()
            {

                 ColorProduct = "#E10A19"
            },

            new ColorProductModel()
            {
                 ColorProduct = "#3bd68f"
            },

            new ColorProductModel()
            {
                ColorProduct = "#7D959F"
            }
        };

        public DetailProductViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        Command AskCmd;
        public Command AskCommand => AskCmd = AskCmd ?? new Command(AskPage);

        private async void AskPage()
        {
            await NavigationService.NavigateAsync(Routes.Chat);
        }

        Command PurchaseCmd;
        public Command PurchaseCommand => PurchaseCmd = PurchaseCmd ?? new Command(PurchaseProduct);

        private void PurchaseProduct()
        {

        }

        Command BackCmd;
        public Command BackCommand => BackCmd = BackCmd ?? new Command(BackToPreviousPage);

        private void BackToPreviousPage()
        {
            NavigationService.GoBackAsync();
        }

        Command ChooseColorCmd;
        public Command ChooseColorCommand => ChooseColorCmd = ChooseColorCmd ?? new Command<ColorProductModel>(ChooseColor);

        private void ChooseColor(ColorProductModel obj)
        {
            if (obj == null || obj.IsColorSelected)
            {
                return;
            }

            obj.IsColorSelected = true;

            foreach (var item in Colors)
            {
                if (item != obj)
                {
                    item.IsColorSelected = false;
                }
            }
        }
    }
}
