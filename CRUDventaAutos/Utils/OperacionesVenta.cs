using CRUDventaAutos.Clases;
using CRUDventaAutos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDventaAutos.Utils
{
    internal class OperacionesVenta : IVentas
    {
        string strConn = @"Server=localhost\SQLEXPRESS;DataBase=CRUDautos;Trusted_Connection=true"; //agregar /SQLEXPRESS a la par de localhost si se utiliza sql server express
        public void DeleteVenta(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    SqlCommand deleteCommand = new SqlCommand("DELETE Ventas WHERE id_Venta = " + id,conn);
                    deleteCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("la Venta "+ id + " ha sido eliminada");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet GetVenta(int id)
        {
            try {
                using(SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    var select = "SELECT top 500 * FROM Ventas WHERE id_Venta = "+ id;
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
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

        public void SaveVenta(Venta venta)
        {
            try {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Ventas VALUES "+
                        "(@fechaVenta, @id_Auto, @id_Cliente, @totalDeVenta)", conn);
                    insertCommand.Parameters.Add(new SqlParameter("fechaVenta", venta.fechaVenta));
                    insertCommand.Parameters.Add(new SqlParameter("id_Auto", venta.id_Auto));
                    insertCommand.Parameters.Add(new SqlParameter("id_Cliente", venta.id_Cliente)); 
                    insertCommand.Parameters.Add(new SqlParameter("totalDeVenta", venta.TotalDeVenta));
                    insertCommand.ExecuteNonQuery();
                    Form1 fPrincipal = new Form1();
                    fPrincipal.LlenarData();
                    conn.Close();
                }
            }
            catch(Exception ) {
                throw;
            }
        }

        public void UpdateVenta(Venta venta, int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("UPDATE Ventas SET " +
                        "fechaVenta = @fechaVenta, idAutoVendido=@idAutoVendido, idCliente = @idCliente, totalDeVenta=@totalDeVenta " +
                        "WHERE id_Venta = "+ id, conn);
                    insertCommand.Parameters.Add(new SqlParameter("fechaVenta", venta.fechaVenta));
                    insertCommand.Parameters.Add(new SqlParameter("idAutoVendido", venta.id_Auto));
                    insertCommand.Parameters.Add(new SqlParameter("idCliente", venta.id_Cliente));
                    insertCommand.Parameters.Add(new SqlParameter("totalDeVenta", venta.TotalDeVenta));
                    insertCommand.ExecuteNonQuery();
                    Form1 fPrincipal = new Form1();
                    fPrincipal.LlenarData();
                    conn.Close();
                    MessageBox.Show("Datos Actualizados");

                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet GetAllVentas()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    var select = "SELECT top 500 * FROM Ventas";
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commandBuilder = new SqlCommandBuilder(dataAdapter);
                    var ds = new DataSet();
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

        internal string BuscarImagen(int id)
        {
            try
            {
                string nombre;
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    var select = "SELECT nombre FROM Imagenes WHERE idImagen = " + id;
                    var comando = new SqlCommand(select, conn);
                    
                    nombre = comando.ExecuteScalar().ToString();
                    conn.Close();
                    return nombre;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deleteVenta(int id)
        {
            throw new NotImplementedException();
        }

        public void updateVenta(Venta venta, int id)
        {
            throw new NotImplementedException();
        }
    }
}
