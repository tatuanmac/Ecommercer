using System;
using Ecommercer.Source.Authentication.Model;
using Ecommercer.Source.Common.Bases;

namespace Ecommercer.Source.Tags.Model
{
    public class TagsModel : ModelBase
    {
        public string Tag_id { get; set; }
        public string Tag_title { get; set; }
        public float TagSize { get; set; }
        public float SizeRadius { get; set; }
        public bool IsSelected { get; set; }
    }
}
