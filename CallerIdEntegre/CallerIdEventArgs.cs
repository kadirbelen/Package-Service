using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eyp_PaketServisv1._2.CallerIdEntegre
{
    public class CallerIdEventArgs:EventArgs
    {
        public Customer Customer { get; set; }
    }
}
