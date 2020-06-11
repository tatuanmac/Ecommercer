using System;
using System.Collections.Generic;
using Ecommercer.Source.Common.Bases;
using Ecommercer.Source.Home.Model;

namespace Ecommercer.Source.Cart.Model
{
    public enum CartEnum
    {
        Current_Order, Pending_Orders, History
    }

    public class CartButton : ModelBase
    {
        public CartEnum Type { get; set; }
        public string Title { get; set; }
        public bool IsSelected { get; set; }
    }
    public class CartModel : ModelBase
    {
        public List<StoreModel> StoreItem { get; set; }
        public float Quantity { get; set; }
        public float TotalPriceItem { get; set; }
    }
}
