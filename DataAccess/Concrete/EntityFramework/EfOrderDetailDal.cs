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
    public class EfOrderDetailDal:EfEntityRepositoryBase<OrderDetail,PackageServiceDbContext>,IOrderDetailDal
    {
        public List<OrderDetailOrProduct> GetOrderDetailsOrProduct(int orderId)
        {
            using (PackageServiceDbContext context = new PackageServiceDbContext())
            {
                var result = from o in context.OrderDetails
                             join p in context.Products
                             on o.ProductId equals p.ProductId
                             where p.IsActive == true && orderId==o.OrderId
                             select new OrderDetailOrProduct
                             {
                                 ProductId = p.ProductId,
                                 OrderDetailId = o.OrderDetailId,
                                 ProductName = p.ProductName,
                                 Quantity = o.Quantity,
                                 UnitPrice = o.UnitPrice

                             };
                return result.ToList();
            }
        }

       

    }
}
