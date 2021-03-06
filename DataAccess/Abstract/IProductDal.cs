using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        List<ProductOrCategoryDetails> GetProductOrCategoryDetails();
        List<ProductStockShow> GetProductStockShows();
        List<ProductNameGet> GetListCategoryId(int categoryId);
    }
}


