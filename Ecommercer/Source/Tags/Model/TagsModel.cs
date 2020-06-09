using System;
using Ecommercer.Source.Authentication.Model;
using Ecommercer.Source.Common.Bases;

namespace Ecommercer.Source.Tags.Model
{
    public class TagsModel: ModelBase
    {
        public UserModel User { get; set; }
        public string Tag_id { get; set; }
        public string Tag_title { get; set; }
    }
}
