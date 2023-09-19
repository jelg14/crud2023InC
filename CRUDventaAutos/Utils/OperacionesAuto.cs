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
     class OperacionesAuto : IAutos
    {
        string strConn = @"Server=localhost\SQLEXPRESS;DataBase=CRUDautos;Trusted_Connection=true"; //agregar /SQLEXPRESS a la par de localhost si se utiliza sql server express

        public void deleteAuto(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    SqlCommand deleteCommand = new SqlCommand("DELETE Autos WHERE id_Auto = " + id, conn);
                    deleteCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("El Auto " + id + " ha sido eliminado");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public DataSet GetAllAutos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    var select = "SELECT top 500 * FROM Autos";
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

        public DataSet GetAuto(int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    var select = "SELECT top 500 * FROM Autos WHERE id_auto = " + id;
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

        public void SaveAuto(Auto auto)
        {
            try {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Autos VALUES "+
                        "(@marca, @modelo, @año, @color, @precio, @estado)", conn);
                    insertCommand.Parameters.Add(new SqlParameter("marca", auto.marca));
                    insertCommand.Parameters.Add(new SqlParameter("modelo", auto.modelo));
                    insertCommand.Parameters.Add(new SqlParameter("año", auto.anio)); 
                    insertCommand.Parameters.Add(new SqlParameter("color", auto.color));
                    insertCommand.Parameters.Add(new SqlParameter("precio", auto.precio));
                    insertCommand.Parameters.Add(new SqlParameter("estado", auto.estado));    
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

        public void updateAuto(Auto auto, int id)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = strConn;
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("UPDATE Autos SET " +
                        "marca = @marca, modelo=@modelo, año = @año, color=@color, " +
                        "precio=@precio, estado=@estado WHERE id_auto = " + id, conn);
                    insertCommand.Parameters.Add(new SqlParameter("marca", auto.marca));
                    insertCommand.Parameters.Add(new SqlParameter("modelo", auto.modelo));
                    insertCommand.Parameters.Add(new SqlParameter("año", auto.anio));
                    insertCommand.Parameters.Add(new SqlParameter("color", auto.color));
                    insertCommand.Parameters.Add(new SqlParameter("precio", auto.precio));
                    insertCommand.Parameters.Add(new SqlParameter("estado", auto.estado));
                    insertCommand.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Datos Actualizados");

                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
