﻿using System;
using Ecommercer.iOS.Renderers;
using Ecommercer.Source.Common.Navigation;
using Xamarin.Forms;
using CoreAnimation;
using CoreGraphics;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(GradientColorStack), typeof(GradientColorStackRenderer))]
namespace Ecommercer.iOS.Renderers
{
    public class GradientColorStackRenderer : VisualElementRenderer<StackLayout>
    {
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
            GradientColorStack stack = (GradientColorStack)this.Element;
            CGColor startColor = stack.StartColor.ToCGColor();

            CGColor endColor = stack.EndColor.ToCGColor();

            #region for Vertical Gradient

            var gradientLayer = new CAGradientLayer();

            #endregion

            #region for Horizontal Gradient

            //var gradientLayer = new CAGradientLayer()
            //{
            //  StartPoint = new CGPoint(0, 0.5),
            //  EndPoint = new CGPoint(1, 0.5)
            //};

            #endregion
            gradientLayer.Frame = rect;
            gradientLayer.Colors = new CGColor[] { startColor, endColor
        };

            NativeView.Layer.InsertSublayer(gradientLayer, 0);
        }
    }
}