using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, PackageServiceDbContext>, IProductDal
    {
        public List<ProductOrCategoryDetails> GetProductOrCategoryDetails()
        {

            using (PackageServiceDbContext context = new PackageServiceDbContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             where p.IsActive == true
                             select new ProductOrCategoryDetails
                             {
                                 ProductId = p.ProductId,
                                 BarcodeNumber = p.BarcodeNumber,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 Stock = p.Stock,
                                 PurchasePrice = p.PurchasePrice,
                                 SalePrice = p.SalePrice,
                                 Statement = p.Statement,
                                 ProductDate = p.ProductDate,
                                 VatRate = p.VatRate,
                                 VatAmount = p.VatAmount
                             };
                return result.ToList();
            }
        }

        public List<ProductStockShow> GetProductStockShows()
        {
            using (PackageServiceDbContext context = new PackageServiceDbContext())
            {
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             where p.IsActive == true
                             select new ProductStockShow
                             {
                                 ProductId = p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 Stock = p.Stock,
                                 ProductDate = p.ProductDate,
                             };
                return result.ToList();
            }
        }
    }
}
