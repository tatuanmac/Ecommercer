﻿using System;
using Ecommercer.Source.Authentication.Model;
using Ecommercer.Source.Common.Bases;

namespace Ecommercer.Source.Cart.Model
{
    public class ShippingAddressModel : ModelBase
    {
        public UserModel User { get; set; }
        public string Shipping_country { get; set; }
        public string Shipping_address { get; set; }
        public string Shipping_zipcode { get; set; }
        public string Shipping_city { get; set; }

    }
}
