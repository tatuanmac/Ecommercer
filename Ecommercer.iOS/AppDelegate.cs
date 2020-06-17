using System;
using System.Collections.Generic;
using System.Linq;
using CoreGraphics;
using FFImageLoading.Forms.Platform;
using Foundation;
using Prism;
using Prism.Ioc;
using UIKit;
using Xamarin.Forms;

namespace Ecommercer.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {

            //UIView statusBar = new UIView(UIApplication.SharedApplication.StatusBarFrame)
            //{
            //    BackgroundColor = UIColor.Yellow
            //};
            //UIApplication.SharedApplication.KeyWindow.AddSubview(statusBar);
            Forms.SetFlags("IndicatorView_Experimental");
            FFImageLoading.Forms.Platform.CachedImageRenderer.Init();
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
        public void Initilinization(UIApplication app, NSDictionary options)
        {
            CachedImageRenderer.Init();
        }

        public UIStatusBarStyle PreferredStatusBarStyle() => UIStatusBarStyle.LightContent;

        public override void OnActivated(UIApplication uiApplication)
        {
            if (UIDevice.CurrentDevice.CheckSystemVersion(13, 0))
            {
                var topBarHeight = UIApplication.SharedApplication.KeyWindow.WindowScene.StatusBarManager.StatusBarFrame.Size.Height;
                
                //UIView statusBar = new UIView(UIApplication.SharedApplication.KeyWindow.WindowScene.StatusBarManager.StatusBarFrame)
                //{
                //    BackgroundColor = UIColor.Red
                //};

                //UIApplication.SharedApplication.KeyWindow.AddSubview(statusBar);
            }
            else
            {
                UIView statusBar = UIApplication.SharedApplication.ValueForKey(new NSString("statusBar")) as UIView;
                if (statusBar.RespondsToSelector(new ObjCRuntime.Selector("setBackgroundColor:")))
                {
                    statusBar.BackgroundColor = UIColor.Red;
                    UIApplication.SharedApplication.StatusBarStyle = UIStatusBarStyle.BlackOpaque;
                }
            }
            base.OnActivated(uiApplication);
        }
    }

    class IOSPlatform : IPlatformInitializer
    {
        public static IOSPlatform Platform => new IOSPlatform();

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}
