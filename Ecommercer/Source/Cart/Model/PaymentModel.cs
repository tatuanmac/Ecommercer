using System;
using Ecommercer.Source.Common.Bases;

namespace Ecommercer.Source.Cart.Model
{
    public enum PaymenEnum
    {
        Personal_shipping_detail, Review_Purchase
    }
    public class PaymentButton: ModelBase
    {
        public PaymenEnum Type { get; set; }
        public string Title { get; set; }
        public bool IsSelected { get; set; }
    }
    public class PaymentModel : ModelBase
    {
        public CartModel Cart { get; set; }
        public float SubTotal { get; set; }
        public float Shipping { get; set; }
        public float TotalPrice { get; set; }
        public PaymentDetail detail { get; set; }
    }
    public class PaymentDetail : ModelBase
    {
        public int Card_number { get; set; }
        public DateTime Card_Ex_date { get; set; }
        public int Card_CVV_Code { get; set; }
        public int Card_Zip_code { get; set; }
        public string Card_fullname { get; set; }
    }
}
