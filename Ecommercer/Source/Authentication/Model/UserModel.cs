using System;
using Ecommercer.Source.Common.Bases;

namespace Ecommercer.Source.Authentication.Model
{
    public class UserModel : ModelBase
    {
        public string User_id { set; get; }
        public string User_name { set; get; }
        public string User_email { set; get; }
        public string User_password { set; get; }
        public string User_fullname { set; get; }
        public string User_address { set; get; }
        public int User_phone_number { set; get; }
        public string User_avatar { set; get; }
    }

}
