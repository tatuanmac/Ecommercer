using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Ecommercer.Source.Deals.Model;
using Ecommercer.Source.Home.Model;

namespace Ecommercer.Source.Deals.Service
{
    public interface IDeal
    {
        Task<List<ProductModel>> GetListMostPopular();
    }
    public class DealsData : IDeal
    {
        public Task<List<ProductModel>> GetListMostPopular()
        {
            var data = new List<ProductModel>
            {
               new ProductModel
               {
                   Product_big_image = "https://www.humanesociety.org/sites/default/files/styles/768x326/public/2018/08/cat-home-441939.jpg?h=83a2eac3&itok=dz3Vkm2B",
                              Product_name = "Mlem mlem mlem mlem mlem mlem mlem",
                              Product_detail = "mlem mlem mlem mlem mlem mlem mlem mlem mlem",
                              Product_price = 499.95
               },
               new ProductModel
               {
                   Product_big_image = "https://www.humanesociety.org/sites/default/files/styles/768x326/public/2018/08/cat-home-441939.jpg?h=83a2eac3&itok=dz3Vkm2B",
                              Product_name = "Mlem mlem mlem mlem mlem mlem mlem",
                              Product_detail = "mlem mlem mlem mlem mlem mlem mlem mlem mlem",
                              Product_price = 899.95
               },
                         new Home.Model.ProductModel
                         {
                              Product_big_image = "https://www.humanesociety.org/sites/default/files/styles/768x326/public/2018/08/cat-home-441939.jpg?h=83a2eac3&itok=dz3Vkm2B",
                              Product_name = "Mlem mlem mlem mlem mlem mlem mlem",
                              Product_detail = "mlem mlem mlem mlem mlem mlem mlem mlem mlem",
                              Product_price = 399.95
                         },
                         new Home.Model.ProductModel
                         {
                              Product_big_image = "https://www.humanesociety.org/sites/default/files/styles/768x326/public/2018/08/cat-home-441939.jpg?h=83a2eac3&itok=dz3Vkm2B",
                              Product_name = "Mlem mlem mlem mlem mlem mlem mlem",
                              Product_detail = "mlem mlem mlem mlem mlem mlem mlem mlem mlem",
                              Product_price = 699.95
                         },
                         new Home.Model.ProductModel
                         {
                              Product_big_image = "https://www.humanesociety.org/sites/default/files/styles/768x326/public/2018/08/cat-home-441939.jpg?h=83a2eac3&itok=dz3Vkm2B",
                              Product_name = "Mlem mlem mlem mlem mlem mlem mlem",
                              Product_detail = "mlem mlem mlem mlem mlem mlem mlem mlem mlem",
                              Product_price = 599.95
                         },
                         new Home.Model.ProductModel
                         {
                              Product_big_image = "https://www.humanesociety.org/sites/default/files/styles/768x326/public/2018/08/cat-home-441939.jpg?h=83a2eac3&itok=dz3Vkm2B",
                              Product_name = "Mlem mlem mlem mlem mlem mlem mlem",
                              Product_detail = "mlem mlem mlem mlem mlem mlem mlem mlem mlem",
                              Product_price = 699.95
                         }

            };
            return Task.FromResult(data);
        }
    }
}
