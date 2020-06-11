using System;
using System.Threading.Tasks;
using Ecommercer.Source.Cart.Model;
using System.Collections.Generic;
using Ecommercer.Source.Home.Model;
using Ecommercer.Source.Authentication.Model;

namespace Ecommercer.Source.Cart.Service
{
    public interface ICart
    {
        Task<List<CartModel>> GetListItemCart();
    }
    public class CartData : ICart
    {
        Task<List<CartModel>> ICart.GetListItemCart()
        {
            var cartData = new List<CartModel>()
            {
                new CartModel
                {
                    StoreItem = new StoreModel
                        {

                             User =  new UserModel
                             {
                                 User_avatar = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/VAN_CAT.png/440px-VAN_CAT.png",
                                 User_fullname = "Black Cat",
                                 User_address = "San Francisco, California"
                             },
                             ProductItem = new List<ProductModel>
                             {
                                    new ProductModel
                                    {
                                       Product_big_image = "https://img.huffingtonpost.com/asset/5e5f7af12600004018b602c0.jpeg",
                                       Product_name = "Mèo loại 1",
                                       Product_ordered = new DateTime(2015,10,4),
                                       Product_status = 1
                                    }
                             }
                         }

                },
                new CartModel
                {
                    StoreItem = new StoreModel
                        {

                             User =  new UserModel
                             {
                                 User_avatar = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/VAN_CAT.png/440px-VAN_CAT.png",
                                 User_fullname = "Black Cat",
                                 User_address = "San Francisco, California"
                             },
                             ProductItem = new List<ProductModel>
                             {
                                    new ProductModel
                                    {
                                       Product_big_image = "https://img.huffingtonpost.com/asset/5e5f7af12600004018b602c0.jpeg",
                                       Product_name = "Mèo loại 1",
                                       Product_ordered = new DateTime(2015,10,4),
                                       Product_status = 1
                                    },
                                    new ProductModel
                                    {
                                       Product_big_image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRxBhrR0O-GB7eaUEdif59NEaTsXUkbjNV-D3lq-OdxqkUC3WyG&usqp=CAU",
                                       Product_name = "Mèo loại 2",
                                       Product_ordered = new DateTime(2018,12,8),
                                       Product_status = 2
                                    }
                             }
                         }

                },
                new CartModel
                {
                    StoreItem = new StoreModel
                        {

                             User =  new UserModel
                             {
                                 User_avatar = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/b1/VAN_CAT.png/440px-VAN_CAT.png",
                                 User_fullname = "Black Cat",
                                 User_address = "San Francisco, California"
                             },
                             ProductItem = new List<ProductModel>
                             {
                                    new ProductModel
                                    {
                                       Product_big_image = "https://img.huffingtonpost.com/asset/5e5f7af12600004018b602c0.jpeg",
                                       Product_name = "Mèo loại 1",
                                       Product_ordered = new DateTime(2015,10,4),
                                       Product_status = 1
                                    },
                                    new ProductModel
                                    {
                                       Product_big_image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcRxBhrR0O-GB7eaUEdif59NEaTsXUkbjNV-D3lq-OdxqkUC3WyG&usqp=CAU",
                                       Product_name = "Mèo loại 2",
                                       Product_ordered = new DateTime(2018,12,8),
                                       Product_status = 2
                                    },
                                    new ProductModel
                                    {
                                       Product_big_image = "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcTTyR3YI3hg-e3CvTpY8yhQKEd7qMA5M359vJKEPT3eU-A6vkzT&usqp=CAU",
                                       Product_name = "Mèo loại 3",
                                       Product_ordered = new DateTime(2020/12/19),
                                       Product_status = 1
                                    }
                             }
                         }
                }
            };
            return Task.FromResult(cartData);
        }
    }
}
