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
    public class OrderDetailManager : IOrderDetailService
    {
        IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public void Add(OrderDetail orderDetail)
        {
            _orderDetailDal.Add(orderDetail);
        }

        public void Delete(OrderDetail orderDetail)
        {
            _orderDetailDal.Delete(orderDetail);
        }

        public List<OrderDetail> GetAll()
        {
            return _orderDetailDal.GetAll();
        }

        public List<OrderDetail> GetById(int orderId)
        {
            return _orderDetailDal.GetAll(p => p.OrderId == orderId);
        }

        public List<OrderDetailOrProduct> GetOrderDetailOrProduct(int orderId)
        {
            return _orderDetailDal.GetOrderDetailsOrProduct(orderId);
        }

        public void Update(OrderDetail orderDetail)
        {
            _orderDetailDal.Update(orderDetail);
        }
    }
}
