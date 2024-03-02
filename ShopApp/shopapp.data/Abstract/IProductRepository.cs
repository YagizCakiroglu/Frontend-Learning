using ShopApp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.data.Abstract
{
    public interface IProductRepository: IRepository<Product>
    {
       List<Product> GetPopularProducts();
       List<Product> GetTop5Products();
    }
}