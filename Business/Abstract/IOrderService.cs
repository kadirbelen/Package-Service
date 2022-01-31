using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IOrderService
    {
        List<Order> GetAll();
        List<OrderOrCustomer> GetCustomerPhoneList(string phone);
        Order GetById(int orderId);
        
        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);
    }
}
