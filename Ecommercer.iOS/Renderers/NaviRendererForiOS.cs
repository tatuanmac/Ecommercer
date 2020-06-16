using System;
using Ecommercer.iOS.Renderers;
using Ecommercer.Source.Common.Navigation;
using UIKit;
using Xamarin.Forms.Platform.iOS;

[assembly: Xamarin.Forms.Dependency(typeof(NaviRendererForiOS))]
namespace Ecommercer.iOS.Renderers
{
    public class NaviRendererForiOS : NavigationRenderer, IGetHeightStatusBar
    {
        nfloat heightNavBar;

        public double GetNavigationHeight()
        {
            heightNavBar = NavigationBar.Bounds.Height;
            return heightNavBar;
        }

        public double GetStatusBarHeight()
        {
            var height = UIApplication.SharedApplication.StatusBarFrame.Height;

            return height;
            
        }

    }
}
