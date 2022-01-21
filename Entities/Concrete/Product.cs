
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Product
    {
        public int ProductId { get; set; }
        public string BarcodeNumber { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public string Statement { get; set; }
        public DateTime ProductDate { get; set; } = DateTime.Now;
        public string VatRate { get; set; }
        public decimal VatAmount { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
