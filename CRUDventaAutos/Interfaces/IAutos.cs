using CRUDventaAutos.Clases;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDventaAutos.Interfaces
{
    internal interface IAutos
    {
        public DataSet GetAuto(int id);
        public DataSet GetAllAutos();
        public void SaveAuto(Auto auto);
        public void deleteAuto(int id);
        public void updateAuto(Auto auto, int id);
    }
}
