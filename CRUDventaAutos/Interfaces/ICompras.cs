﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDventaAutos.Clases;


namespace CRUDventaAutos.Interfaces
{
    internal interface ICompras
    {
       public DataSet GetCompra(int id);
        public DataSet GetAllCompras();
    }
}
