using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetById(int productId);
        List<Product> GetByIdList(int categoryId);
        void Add(Product product);
        void Update(Product product);
        void Delete(Product product);
        List<ProductOrCategoryDetails> GetProductOrCategoryDetails();
        List<ProductOrCategoryDetails> GetProductSearch(string key);
        List<ProductStockShow> GetProductStockSearch(string key);
        List<ProductStockShow> GetProductSearchDate(DateTime dateTime1, DateTime dateTime2);

    }
}
