using System;
using Ecommercer.Source.Authentication.Model;
using Ecommercer.Source.Common.Bases;
using Ecommercer.Source.Home.Model;

namespace Ecommercer.Source.Profile.Model
{
    public class ProfileModel : ModelBase
    {
        public StoreModel store { get; set; }   
    }
}
