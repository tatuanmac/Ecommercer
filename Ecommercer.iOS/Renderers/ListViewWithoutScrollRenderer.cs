using System;
using Ecommercer.iOS.Renderers;
using Ecommercer.Source.Common.Renderer;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ListViewWithoutScroll), typeof(ListViewWithoutScrollRenderer))]
namespace Ecommercer.iOS.Renderers
{
    public class ListViewWithoutScrollRenderer : ListViewRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.ListView> e)
        {
            base.OnElementChanged(e);
            if (e.OldElement != null)
            {
                // Unsubscribe
            }
            if (e.NewElement != null)
            {
                Control.ScrollEnabled = false;
            }
        }
    }
}