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
    public class OperacionesAuto : IAutos
    {
        public void deleteAuto(int id)
        {
            throw new NotImplementedException();
        }

        public DataSet GetAllAutos(int id)
        {
            throw new NotImplementedException();
        }

        public DataSet GetAuto(int id)
        {
            throw new NotImplementedException();
        }

        void IAutos.saveAuto(Auto auto)
        {
            throw new NotImplementedException();
        }

        void IAutos.updateAuto(Auto auto)
        {
            throw new NotImplementedException();
        }
    }
}
