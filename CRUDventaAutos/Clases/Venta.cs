using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDventaAutos.Clases
{
    internal class Venta
    {
        public DateTime fechaVenta { get; set; }
        public int id_Auto { get; set; }
        public int id_Cliente { get; set; }
        public decimal TotalDeVenta { get; set; }
    }
}
