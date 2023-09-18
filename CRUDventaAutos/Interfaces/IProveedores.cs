using CRUDventaAutos.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDventaAutos.Interfaces
{
    internal interface IProveedores
    {
        public Proveedor GetProveedor(int id);
        public DataSet GetAllProveedores();
    }
}
