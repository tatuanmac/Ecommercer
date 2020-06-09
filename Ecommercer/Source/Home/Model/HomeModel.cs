using System;
using System.Collections.Generic;
using Ecommercer.Source.Common.Bases;

namespace Ecommercer.Source.Home.Model
{
    public enum HomeEnum
    {
        MostPopular, Featured, TopSellers, Following
    }

    public class HomeButton : ModelBase
    {
        public HomeEnum Type { get; set; }
        public string Title { get; set; }
        public bool IsSelected { get; set; }
    }

    public class HomeModel : ModelBase
    {

        public List<StoreModel> Store { get; set; }
    }
}
