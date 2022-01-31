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
    public class EfOrderDal : EfEntityRepositoryBase<Order, PackageServiceDbContext>, IOrderDal
    {
        public List<OrderOrCustomer> GetOrderOrCustomerDetails(string phone)
        {
            using (PackageServiceDbContext context = new PackageServiceDbContext())
            {
                var result = from o in context.Orders
                             join c in context.Customers
                             on o.CustomerId equals c.CustomerId
                             where c.Phone1 == phone
                             select new OrderOrCustomer
                             {
                                 Name = c.Name,
                                 Surname = c.Surname,
                                 Address1 = c.Address1,
                                 Phone1 = c.Phone1,
                                 OrderDate = o.OrderDate,
                                 OrderDateHour = o.OrderDateHour,

                             };
                return result.ToList();
            }
        }
    }
}
