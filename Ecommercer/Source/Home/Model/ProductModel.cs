using System;
using Ecommercer.Source.Common.Bases;

namespace Ecommercer.Source.Home.Model
{
    public class ProductModel : ModelBase
    {
        public string Product_id { get; set; }
        public ProductColor Product_color { get; set; }
        public string Product_big_image { get; set; }
        public string Product_name { get; set; }
        public string Product_type { get; set; }
        public string Product_detail { get; set; }
        public float Product_price { get; set; }

    }

    public class ProductColor : ModelBase
    {
        public string Product_image { get; set; }
        public string Product_color { get; set; }

    }
}
