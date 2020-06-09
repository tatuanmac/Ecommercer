using System;
using Ecommercer.Source.Authentication.Model;
using Ecommercer.Source.Common.Bases;

namespace Ecommercer.Source.Chat.Model
{
    public class ChatModel: ModelBase
    {
        public UserModel user { get; set; }
        public string Store_id { get; set; }
        public string Message_contents { get; set; }
        public DateTime Message_time { get; set; }
    }
}
