using CRUDventaAutos.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDventaAutos.Interfaces
{
    internal interface IClientes
    {
        public Cliente getCliente(int id);
        public DataSet GetAllClientes();

    }
}
