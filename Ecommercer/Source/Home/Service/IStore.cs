using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ecommercer.Source.Home.Model;

namespace Ecommercer.Source.Home.Service
{
    public interface IStore
    {
        Task<List<StoreModel>> ListStore();
    }
    public class StoreData : IStore
    {
        public Task<List<StoreModel>> ListStore()
        {
            var listStore = new List<StoreModel>
            {
                new StoreModel
                {
                    Store_id = "1",
                    Store_rate = 3,
                    Store_review = 10,
                    User = new Authentication.Model.UserModel
                    {
                         User_avatar = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/VAN_CAT.png/440px-VAN_CAT.png",
                         User_fullname = "Black Cat",
                         User_address = "San Francisco, California"
                    }
                },
                new StoreModel
                {
                    Store_id = "1",
                    Store_rate = 3,
                    Store_review = 122,
                    User = new Authentication.Model.UserModel
                    {
                         User_avatar = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/VAN_CAT.png/440px-VAN_CAT.png",
                         User_fullname = "Mlem mlem mlem",
                         User_address = "Ha noi, Vietnam"
                    }
                },
                new StoreModel
                {
                    Store_id = "1",
                    Store_rate = 3,
                    Store_review = 12002,
                    User = new Authentication.Model.UserModel
                    {
                         User_avatar = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/VAN_CAT.png/440px-VAN_CAT.png",
                         User_fullname = "Binh bong banh",
                         User_address = "San Francisco, California"
                    }
                }
            };
            return Task.FromResult(listStore);
        }
    }

}
