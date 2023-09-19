using CRUDventaAutos.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDventaAutos.Interfaces
{
    internal interface IVentas
    {
       public DataSet GetVenta(int id);
       public DataSet GetAllVentas();
        public void SaveVenta(Venta venta);
        public void deleteVenta(int id);
        public void updateVenta(Venta venta, int id);
    }
}
