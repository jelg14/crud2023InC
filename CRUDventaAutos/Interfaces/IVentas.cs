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
       public void DeleteVenta(int id);
       public void UpdateVenta(Venta venta, int id);

    }
}
