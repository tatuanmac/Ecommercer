using System;
using Prism;
using Prism.Mvvm;
using Prism.Navigation;

namespace Ecommercer.Source.Common.Bases
{
    public class TabbedViewModelBase : BindableBase, IActiveAware
    {
        bool isActive;

        readonly INavigationService navigationService;
        public INavigationService NavigationService => navigationService;

        public TabbedViewModelBase(INavigationService navigationService)
        {
            this.navigationService = navigationService;
        }
        
        
        public bool IsActive { get => isActive; set { SetProperty(ref isActive, value, TabActiveChanged); } }

        public virtual void TabActiveChanged()
        {
            IsActiveChanged?.Invoke(this, EventArgs.Empty);
        }

        public event EventHandler IsActiveChanged;

    }
}
