using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class OrderOrCustomer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address1 { get; set; }
        public string Phone1 { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderDateHour { get; set; }
    }
}
