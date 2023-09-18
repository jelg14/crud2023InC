using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDventaAutos.Clases;
using CRUDventaAutos.Interfaces;

namespace CRUDventaAutos.Utils
{
    public class OperacionesCliente : IClientes
    {
        public DataSet GetAllClientes()
        {
            throw new NotImplementedException();
        }

        Cliente IClientes.getCliente(int id)
        {
            throw new NotImplementedException();
        }
    }
}
