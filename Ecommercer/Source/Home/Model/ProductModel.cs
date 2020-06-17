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
        public double Product_price { get; set; }
        public int Product_status { get; set; }
        public DateTime Product_ordered { get; set; }
        public ColorProductModel Color_Product { set; get; }

        public string Status
        {
            get
            {
                if (Product_status == 1)
                {
                    return "Shipped";
                }
                else
                {
                    return "Canceled";
                }
            }
        }
        public string Color
        {
            get
            {
                if (Product_status == 1)
                {
                    return "#28BF4C";
                }
                else
                {
                    return "#F73D34";
                }
            }
        }
    }

    public class ProductColor : ModelBase
    {
        public string Product_image { get; set; }
        public string Product_color { get; set; }

    }
}
