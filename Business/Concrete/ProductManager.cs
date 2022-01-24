using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            return _productDal.GetAll(p=>p.IsActive==true);
        }
        

        public void Update(Product product)
        {
             _productDal.Update(product);
        }

    
        public Product GetById(int productId)
        {
            return _productDal.Get(p => p.ProductId == productId);
        }

        public List<ProductOrCategoryDetails> GetProductOrCategoryDetails()
        {
            return _productDal.GetProductOrCategoryDetails();
        }

        public List<ProductOrCategoryDetails> GetProductSearch(string key)
        {
            return _productDal.GetProductOrCategoryDetails().Where(p => p.ProductName.ToLower().Contains(key.ToLower().Trim())).ToList();
        }

        public List<ProductStockShow> GetProductStockSearch(string key)
        {
            return _productDal.GetProductStockShows().Where(p => p.CategoryName == key).ToList();
        }

        public List<ProductStockShow> GetProductSearchDate(DateTime dateTime1,DateTime dateTime2)
        {
            return _productDal.GetProductStockShows().Where(p => p.ProductDate > dateTime1 & p.ProductDate < dateTime2).ToList();
        }

        public List<ProductNameGet> GetByIdList(int categoryId)
        {
            return _productDal.GetListCategoryId(categoryId);

        }
    }
}
