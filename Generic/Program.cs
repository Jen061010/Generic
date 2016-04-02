using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Program
    {
        static void Main(string[] args)
        {
            var clientes = new Clientes();
            var facturas = new Facturas();
            //var x = new Padre<Clientes>();
            //var y = new Padre<Facturas>();

            clientes.Save();
            facturas.Save();


        }
    }
}
