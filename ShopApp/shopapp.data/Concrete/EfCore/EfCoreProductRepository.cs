using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.data.Abstract;
using ShopApp.entity;

namespace ShopApp.data.Concrete.EfCore
{
    public class EfCoreProductRepository : 
        EfCoreGenericRepository<Product, ShopContext>, IProductRepository
    {
        public List<Product> GetPopularProducts()
        {
            using(var context = new ShopContext())
            {
                return context.Products.ToList();
            }
        }

        public List<Product> GetTop5Products()
        {
            throw new System.NotImplementedException();
        }
    }
}