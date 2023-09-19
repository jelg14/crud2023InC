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
    public partial class BuscarCompra : Form
    {
        OperacionesCompra oc = new OperacionesCompra();
        DataSet dsCompra = new DataSet();
        BindingSource bs = new BindingSource();
        public BuscarCompra()
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
            dsCompra = oc.GetCompra(int.Parse(txtIdCompra.Text));
            bs.DataSource = dsCompra.Tables[0];
            actualizarData(bs);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dsCompra = oc.GetAllCompras();
            bs.DataSource = dsCompra.Tables[0];
            actualizarData(bs);
        }
    }
}
