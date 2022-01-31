using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductStockShow
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public DateTime ProductDate { get; set; }
    }
}
