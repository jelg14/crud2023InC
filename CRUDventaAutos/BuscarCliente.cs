using CRUDventaAutos.Clases;
using CRUDventaAutos.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUDventaAutos
{

    public partial class BuscarCliente : Form
    {
        OperacionesCliente oc = new OperacionesCliente();
        DataSet dsCliente = new DataSet();
        BindingSource bs = new BindingSource();
        public BuscarCliente()
        {
            InitializeComponent();
        }
        private void actualizarData(BindingSource bs)
        {
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
            dataGridView1.ReadOnly = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dsCliente = oc.GetAllClientes();
            bs.DataSource = dsCliente.Tables[0];
            actualizarData(bs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsCliente = oc.getCliente(int.Parse(txtIdCliente.Text));
            bs.DataSource = dsCliente.Tables[0];
            actualizarData(bs);
        }
    }
}
