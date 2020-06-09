using System;
using Ecommercer.iOS.Renderers;
using Ecommercer.Source.Common.Renderer;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(BorderLessEntry), typeof(EntryRenderers))]

namespace Ecommercer.iOS.Renderers
{
    public class EntryRenderers: EntryRenderer
    {
        public EntryRenderers()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BorderStyle = UITextBorderStyle.None;
            }
        }
    }
}
