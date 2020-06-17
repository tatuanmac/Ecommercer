using System;
using System.Drawing;
using Ecommercer.Source.Common.Bases;

namespace Ecommercer.Source.Home.Model
{
    public class ColorProductModel : ModelBase
    {
        public string ColorProduct { set; get; }

        public bool IsColorSelected { set; get; }
        public string Product_image { get; set; }
        public ColorProductModel()
        {


        }
    }
}
