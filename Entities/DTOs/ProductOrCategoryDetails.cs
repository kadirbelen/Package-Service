using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductOrCategoryDetails
    {
        public int ProductId { get; set; }
        public string BarcodeNumber { get; set; }
        public string CategoryName { get; set; }
        public string ProductName { get; set; }
        public int Stock { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public string Statement { get; set; }
        public DateTime ProductDate { get; set; } 
        public string VatRate { get; set; }
        public decimal VatAmount { get; set; }
    }
}
