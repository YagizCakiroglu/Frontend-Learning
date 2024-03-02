using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShopApp.business.Abstract;
using ShopApp.data.Abstract;
using ShopApp.data.Concrete.EfCore;
using ShopApp.entity;

namespace ShopApp.business.Concrete
{
    public class ProductManager: IProductService
    {
        private IProductRepository _productRepository;
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public void Create(Product entity)
        {
            // iş kuralları uygula
            _productRepository.Create(entity);
        }

        public void Delete(Product entity)
        {
            // iş kuralları
            _productRepository.Delete(entity);
        }

        public List<Product> GetAll()
        {            
            return _productRepository.GetAll();
        }

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }
    }
}