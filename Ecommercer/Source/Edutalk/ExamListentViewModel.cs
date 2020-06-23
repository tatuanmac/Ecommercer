using System;
using System.Collections.Generic;
using Ecommercer.Source.Common.Bases;
using Prism.Navigation;
using Xamarin.Forms;

namespace Ecommercer.Source.Edutalk
{
    public class ExamListentViewModel : ViewModelBase
    {
        public bool IsPlaying { get; set; } = true;

        public ExamListentViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        Command PlayCmd;

        public Command PlayCommnad => PlayCmd = PlayCmd ?? new Command(StatusListening);

        private void StatusListening()
        {
            IsPlaying = !IsPlaying;
        }
    }
}
