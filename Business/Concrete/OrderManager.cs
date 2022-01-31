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
    public class OrderManager : IOrderService
    {
        IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void Add(Order order)
        {
            _orderDal.Add(order);
        }

        public void Delete(Order order)
        {
            _orderDal.Delete(order);
        }

        public List<Order> GetAll()
        {
            return _orderDal.GetAll();
        }

        public Order GetById(int orderId)
        {
            return _orderDal.Get(p => p.OrderId == orderId);
        }

        public List<OrderOrCustomer> GetCustomerPhoneList(string phone)
        {
            return _orderDal.GetOrderOrCustomerDetails(phone);
        }

        public void Update(Order order)
        {
            _orderDal.Update(order);
        }
    }
}
