using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ecommercer.Source.Deals.Model;

namespace Ecommercer.Source.Deals.Service
{
    public interface IDeal
    {
        Task<List<DealModel>> GetListMostPopular();
    }
    public class DealsData : IDeal
    {
        public Task<List<DealModel>> GetListMostPopular()
        {
            var data = new List<DealModel>
            {
                new DealModel
                {
                     Product = new List<Home.Model.ProductModel>
                     {
                         new Home.Model.ProductModel
                         {
                              Product_big_image = "https://www.humanesociety.org/sites/default/files/styles/768x326/public/2018/08/cat-home-441939.jpg?h=83a2eac3&itok=dz3Vkm2B",
                              Product_name = "Mlem mlem mlem mlem mlem mlem mlem",
                              Product_detail = "mlem mlem mlem mlem mlem mlem mlem mlem mlem",
                              Product_price = 499.95f
                         },
                         new Home.Model.ProductModel
                         {
                              Product_big_image = "https://www.humanesociety.org/sites/default/files/styles/768x326/public/2018/08/cat-home-441939.jpg?h=83a2eac3&itok=dz3Vkm2B",
                              Product_name = "Mlem mlem mlem mlem mlem mlem mlem",
                              Product_detail = "mlem mlem mlem mlem mlem mlem mlem mlem mlem",
                              Product_price = 899.95f
                         },
                         new Home.Model.ProductModel
                         {
                              Product_big_image = "https://www.humanesociety.org/sites/default/files/styles/768x326/public/2018/08/cat-home-441939.jpg?h=83a2eac3&itok=dz3Vkm2B",
                              Product_name = "Mlem mlem mlem mlem mlem mlem mlem",
                              Product_detail = "mlem mlem mlem mlem mlem mlem mlem mlem mlem",
                              Product_price = 399.95f
                         },
                         new Home.Model.ProductModel
                         {
                              Product_big_image = "https://www.humanesociety.org/sites/default/files/styles/768x326/public/2018/08/cat-home-441939.jpg?h=83a2eac3&itok=dz3Vkm2B",
                              Product_name = "Mlem mlem mlem mlem mlem mlem mlem",
                              Product_detail = "mlem mlem mlem mlem mlem mlem mlem mlem mlem",
                              Product_price = 699.95f
                         },
                         new Home.Model.ProductModel
                         {
                              Product_big_image = "https://www.humanesociety.org/sites/default/files/styles/768x326/public/2018/08/cat-home-441939.jpg?h=83a2eac3&itok=dz3Vkm2B",
                              Product_name = "Mlem mlem mlem mlem mlem mlem mlem",
                              Product_detail = "mlem mlem mlem mlem mlem mlem mlem mlem mlem",
                              Product_price = 599.95f
                         },
                         new Home.Model.ProductModel
                         {
                              Product_big_image = "https://www.humanesociety.org/sites/default/files/styles/768x326/public/2018/08/cat-home-441939.jpg?h=83a2eac3&itok=dz3Vkm2B",
                              Product_name = "Mlem mlem mlem mlem mlem mlem mlem",
                              Product_detail = "mlem mlem mlem mlem mlem mlem mlem mlem mlem",
                              Product_price = 699.95f
                         }
                     }
                }
            };
            return Task.FromResult(data);
        }
    }
}
