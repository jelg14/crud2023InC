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
    public partial class BuscarProveedores : Form
    {
        OperacionesProveedores op = new OperacionesProveedores();
        DataSet dsProveedor = new DataSet();
        BindingSource bs = new BindingSource();
        public BuscarProveedores()
        {
            InitializeComponent();
        }

        private void actualizarData(BindingSource bs)
        {
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
            dataGridView1.ReadOnly = true;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            dsProveedor = op.GetProveedor(int.Parse(textBox1.Text));
            bs.DataSource = dsProveedor.Tables[0];
            actualizarData(bs);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dsProveedor = op.GetAllProveedores();
            bs.DataSource = dsProveedor.Tables[0];
            actualizarData(bs);
        }
    }
}
