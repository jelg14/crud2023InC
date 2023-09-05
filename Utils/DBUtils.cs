using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUD2023.Clases;

namespace CRUD2023.Utils
{
    public  class SearchUtils
    {
        public DataSet BuscarAlumnoCarnet(int Carnet)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = @"Server=localhost\SQLEXPRESS;DataBase=PrograIII2023;Trusted_Connection=true";
                    conn.Open();
                    var select = "SELECT * FROM Alumno WHERE carnet = " + Carnet;
                    //SELECT * FROM ALUMNO WHERE CARNE = 155
                    var dataAdapter = new SqlDataAdapter(select, conn);
                    var commanBuilder = new SqlCommandBuilder(dataAdapter);
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
        public void EditarAlumnoDB(Alumno alumno,int idAlumno)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = @"Server=localhost\SQLEXPRESS;DataBase=PrograIII2023;Trusted_Connection=true";
                    conn.Open();
                    SqlCommand insertCommand = new SqlCommand("UPDATE  Alumno SET" +
                        "Carnet = @Carnet," +
                        "PrimerNombre = @PrimerNombre," +
                        "SegundoNombre = @SegundoNombre," +
                        "PrimerApellido = @PrimerApellido," +
                        "SegundoApellido = @SegundoApellido," +
                        "Celular = @Celular," +
                        "TelefonoCasa = @TelefonoCasa" +
                        "WHERE ID =" + idAlumno, conn);

                    insertCommand.Parameters.Add(new SqlParameter("Carnet", alumno.Carne));
                    insertCommand.Parameters.Add(new SqlParameter("PrimerNombre", alumno.PrimerNombre));
                    insertCommand.Parameters.Add(new SqlParameter("SegundoNombre", alumno.SegundoNombre));
                    insertCommand.Parameters.Add(new SqlParameter("PrimerApellido", alumno.PrimerApellido));
                    insertCommand.Parameters.Add(new SqlParameter("SegundoApellido", alumno.SegundoApellido));
                    insertCommand.Parameters.Add(new SqlParameter("Celular", alumno.Celular));
                    insertCommand.Parameters.Add(new SqlParameter("TelefonoCasa", alumno.TelefonoCasa));
                    insertCommand.ExecuteScalar();
                    MessageBox.Show("Editado");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                throw;
            }
        }
    }
}
