using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Facturas:Padre<Facturas>
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
    }
}
