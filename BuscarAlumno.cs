using CRUD2023.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD2023
{
    public partial class BuscarAlumno : Form
    {
        public BuscarAlumno()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataSet dsAlumno = new DataSet();
            SearchUtils searchU = new SearchUtils();
            dsAlumno = searchU.BuscarAlumnoCarnet(int.Parse(txtCarne.Text));
            BindingSource bs = new BindingSource();
            bs.DataSource = dsAlumno.Tables[0];
            dataGridView1.DataSource = bs;  
            dataGridView1.ReadOnly = true;
        }
    }
}
