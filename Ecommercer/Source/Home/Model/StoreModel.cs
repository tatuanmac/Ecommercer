using System;
using System.Collections.Generic;
using Ecommercer.Source.Authentication.Model;
using Ecommercer.Source.Common.Bases;

namespace Ecommercer.Source.Home.Model
{
    public class StoreModel : ModelBase
    {
        public UserModel User { get; set; }
        public string Store_id { get; set; }
        public int Store_review { get; set; }
        public float Store_rate { get; set; }
        public List<ProductModel> ProductItem { get; set; }
        public int Quantily { get; set; }
        public float HeightRow { get => (ProductItem.Count + 1) * 96; set { } }
    }
}
