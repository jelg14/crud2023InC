using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDventaAutos.Clases
{
    public class Compra
    {
        public DateTime FechaCompra { get; set; }
        public int id_Proveedor { get; set; }
        public int id_Auto { get; set; }

        public decimal PrecioCompra { get; set; }
    }
}
