using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopApp.business.Abstract
{
    public interface IProductService
    {
        Product GetById(int id);

        List<Product> GetAll();

        void Create(Product entity);

        void Update(Product entity);
        void Delete(Product entity);
    }
}