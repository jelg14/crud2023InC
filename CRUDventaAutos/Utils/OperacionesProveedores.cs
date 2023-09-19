using CRUDventaAutos.Clases;
using CRUDventaAutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDventaAutos.Utils
{
    internal class OperacionesProveedores : IProveedores
    {

        string strConn = @"Server=localhost\SQLEXPRESS;DataBase=CRUDautos;Trusted_Connection=true"; //agregar /SQLEXPRESS a la par de localhost si se utiliza sql server express
        DataSet ds = new DataSet();
        public DataSet GetAllProveedores()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    var select = "SELECT top 500 * FROM Proveedores";
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Fill(ds);
                    conn.Close();
                    return ds;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet GetProveedor(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    var select = "SELECT top 500 * FROM Proveedores WHERE id_proveedor = " + id;
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    dataAdapter.Fill(ds);
                    conn.Close();
                    return ds;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
