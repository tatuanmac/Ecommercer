using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ecommercer.Source.Home.Model;

namespace Ecommercer.Source.Home.Service
{
    public interface IStore
    {
        Task<List<StoreModel>> ListStore();
        Task<List<ProductModel>> ListProduct();
    }
    public class StoreData : IStore
    {
        public Task<List<ProductModel>> ListProduct()
        {
            var ListProduct = new List<ProductModel> {
                new ProductModel {
                     Product_big_image = "https://tainghe.com.vn/media/product/1615-tai-nghe-beats-studio-3-wireless--1-.jpg",
                     Product_name = "Tai nghe Beats Studio 3 Wireless",
                     Product_detail = "Mã hàng: 11235 | Thương hiệu: Beats",
                     Product_price = 6.990
                },
                new ProductModel {
                     Product_big_image = "https://tainghe.com.vn/media/lib/2571_MWP22_AV1.jpg",
                     Product_name = "Tai nghe không dây Apple Airpods Pro",
                     Product_detail = "Mã hàng: 13541 | Thương hiệu: Apple",
                     Product_price = 5.190
                },
                new ProductModel {
                     Product_big_image = "https://tainghe.com.vn/media/product/2454_new_andromeda_backs.png",
                     Product_name = "Tai nghe Campfire Andromeda 2019",
                     Product_detail = "Mã hàng: 13546 | Thương hiệu: Campfire",
                     Product_price = 23.990
                },
                new ProductModel {
                     Product_big_image = "https://tainghe.com.vn/media/product/2493_sabbat_e12_camo_green_3.png",
                     Product_name = "Tai nghe True Wireless Sabbat E12 Ultra",
                     Product_detail = "Mã hàng: 13401 | Thương hiệu: Sabbat",
                     Product_price = 1.250
                },
                new ProductModel {
                     Product_big_image = "https://tainghe.com.vn/media/product/2440_xuanvua_audio_sony_wf_1000xm3_2.jpg",
                     Product_name = "Tai nghe True Wireless Sony WF-1000XM3",
                     Product_detail = "Mã hàng: 13367 | Thương hiệu: Sony",
                     Product_price = 4.490
                },
                new ProductModel {
                     Product_big_image = "https://tainghe.com.vn/media/product/2434_613om5fxwtl__sl1200_.jpg",
                     Product_name = "Tai nghe plantronics BackBeat GO 810",
                     Product_detail = "Thương hiệu: Plantronics",
                     Product_price = 3.590
                },

            };
            return Task.FromResult(ListProduct);
        }

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
