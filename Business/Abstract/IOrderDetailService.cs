using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    interface IOrderDetailService
    {
        List<OrderDetail> GetAll();
        List<OrderDetail> GetById(int orderId);
        List<OrderDetailOrProduct> GetOrderDetailOrProduct(int orderId);
        void Add(OrderDetail orderDetail);
        void Update(OrderDetail orderDetail);
        void Delete(OrderDetail orderDetail);
    }
}
