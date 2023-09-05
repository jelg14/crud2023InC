using CRUD2023.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD2023
{
    public partial class EditarAlumno : Form
    {
        private int idAlumno = 0;
        public EditarAlumno()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataSet dsAlumno = new DataSet();
            SearchUtils searchU = new SearchUtils();
            dsAlumno = searchU.BuscarAlumnoCarnet(int.Parse(txtCarne.Text));
            LlenarFormulario(dsAlumno);
        }
        private void LlenarFormulario(DataSet dsAlumno)
        {
            foreach (DataRow filaAlumno in dsAlumno.Tables[0].Rows)
            {
                idAlumno = Convert.ToInt16(filaAlumno["id"]);
                txtPrimerNombre.Text = filaAlumno["PrimerNombre"].ToString();
                txtSegundoNombre.Text = filaAlumno["SegundoNombre"].ToString();
                txtPrimerApellido.Text = filaAlumno["PrimerApellido"].ToString();
                txtSegundoApellido.Text = filaAlumno["SegundoApellido"].ToString();
                txtCelular.Text = filaAlumno["Celular"].ToString();
                txtTelefonoCasa.Text = filaAlumno["TelefonoCasa"].ToString();
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //DELETE FROM TABLE WHERE CAMPO = VALOR
        }
    }
}
