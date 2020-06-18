using System;
using Ecommercer.Source.Common.Bases;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Chat.ViewModels
{
    public class ChatViewModel : ViewModelBase
    {
        
        public ChatViewModel(INavigationService navigationService) : base(navigationService)
        {

        }

        Command MenuCmd;
        public Command MenuCommand => MenuCmd = MenuCmd ?? new Command(MenuChat);

        private void MenuChat()
        {

        }

        Command BackCmd;
        public Command BackCommand => BackCmd = BackCmd ?? new Command(BackToPreviousPage);

        private void BackToPreviousPage()
        {
            NavigationService.GoBackAsync();
        }

        Command SendCmd;
        public Command SendCommand => SendCmd = SendCmd ?? new Command(SendMessage);

        private void SendMessage()
        {

        }
    }
}
