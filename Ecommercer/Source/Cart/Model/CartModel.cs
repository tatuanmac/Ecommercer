using System;
using System.Collections.Generic;
using Ecommercer.Source.Common.Bases;
using Ecommercer.Source.Home.Model;

namespace Ecommercer.Source.Cart.Model
{
    public class CartModel : ModelBase
    {
        public List<StoreModel> StoreItem { get; set; }
        public float Quantity { get; set; }
        public float TotalPriceItem { get; set; }
    }
}
