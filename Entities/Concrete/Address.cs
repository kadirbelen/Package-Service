using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string AddressDescription { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
