using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDventaAutos.Clases;
using CRUDventaAutos.Interfaces;

namespace CRUDventaAutos.Utils
{
    public class OperacionesCliente : IClientes
    {
        string strConn = @"Server=localhost\SQLEXPRESS;DataBase=CRUDautos;Trusted_Connection=true"; //agregar /SQLEXPRESS a la par de localhost si se utiliza sql server express
        DataSet ds = new DataSet();
        public DataSet GetAllClientes()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    var select = "SELECT top 500 * FROM Clientes";
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

        public DataSet getCliente(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    var select = "SELECT top 500 * FROM Clientes WHERE id_cliente = " + id;
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
