
using CRUD2023.Clases;
using System.Data;
using System.Data.SqlClient;

namespace CRUD2023
{
    public partial class Form1 : Form
    {
        private Stack<Alumno> PilaAlumno = new Stack<Alumno>();

        public Form1()
        {
            InitializeComponent();
        }

        private void opcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void agregarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var agregar = new AgregarAlumno())
            {
                agregar.ShowDialog();
            }
        }

        private void buscarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var buscar = new BuscarAlumno()) { buscar.ShowDialog(); }
        }

        private void editarAlumnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var editar = new EditarAlumno()) { editar.ShowDialog(); };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola hiciste clic en el boton guardar");
            PilaAlumno.Push(new Alumno
            {
                Carne = 464,
                Celular = 3423,
                PrimerNombre = "Cristiano",
                SegundoNombre = "Lionel",
                PrimerApellido = "Dos Santos",
                SegundoApellido = "Messi",
                TelefonoCasa = 456465
            });

            LLenarData();
        }
        public void LLenarData()
        {

            DataSet ds = new DataSet();
            ds = ObtenerAlumnos();
            BindingSource bs = new BindingSource();
            bs.DataSource = ds.Tables[0]; ;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
            dataGridView1.ReadOnly = true;
        }

        public DataSet ObtenerAlumnos()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = @"Server=localhost\SQLEXPRESS;DataBase=PrograIII2023;Trusted_Connection=true";
                    conn.Open();
                    var select = "SELECT Top 100 * FROM Alumno";
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

        public void AgregarAlumnoDB(Alumno alumno)
        {

            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    conn.ConnectionString = @"Server=localhost\SQLEXPRESS;DataBase=PrograIII2023;Trusted_Connection=true";
                    conn.Open();
                    //Insert into tabla values (valor1,valor2...)
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Alumno " +
                        "VALUES(@PrimerNombre,@SegundoNombre," +
                        "@PrimerApellido,@SegundoApellido,@Carne,@Celular,@TelefonoCasa)", conn);
                    insertCommand.Parameters.Add(new SqlParameter("Carne", alumno.Carne));
                    insertCommand.Parameters.Add(new SqlParameter("PrimerNombre", alumno.PrimerNombre));
                    insertCommand.Parameters.Add(new SqlParameter("SegundoNombre", alumno.SegundoNombre));
                    insertCommand.Parameters.Add(new SqlParameter("PrimerApellido", alumno.PrimerApellido));
                    insertCommand.Parameters.Add(new SqlParameter("SegundoApellido", alumno.SegundoApellido));
                    insertCommand.Parameters.Add(new SqlParameter("Celular", alumno.Celular));
                    insertCommand.Parameters.Add(new SqlParameter("TelefonoCasa", alumno.TelefonoCasa));
                    //insertCommand.ExecuteScalar();
                    insertCommand.ExecuteNonQuery();
                    LLenarData();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}