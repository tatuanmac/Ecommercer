using System;
using System.Collections.Generic;
using Ecommercer.Source.Common.Bases;
using Ecommercer.Source.Home.Model;

namespace Ecommercer.Source.Deals.Model
{
    public enum DealEnum
    {
        Most_Popular, Featured, Deals_of_the_month
    }

    public class DealButton : ModelBase
    {
        public DealEnum Type { get; set; }
        public string Title { get; set; }
        public bool IsSelected { get; set; }
    }

    public class DealModel : ModelBase
    {
        public ProductModel Product { get; set; }
    }
}
