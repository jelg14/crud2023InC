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
    public partial class BuscarAutos : Form
    {
        DataSet dsVenta = new DataSet();
        OperacionesAuto oa = new OperacionesAuto();
        BindingSource bs = new BindingSource();
        public BuscarAutos()
        {
            InitializeComponent();
        }

        private void BuscarAutos_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LlenarData();
        }

        public void LlenarData()
        {
            dsVenta = oa.GetAllAutos();
            bs.DataSource = dsVenta.Tables[0]; ;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
            dataGridView1.ReadOnly = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsVenta = oa.GetAuto(int.Parse(txtIDauto.Text));
            bs.DataSource = dsVenta.Tables[0] ;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
            dataGridView1.ReadOnly = true;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var result = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Eliminar registro", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int idEliminar = Convert.ToInt16(row.Cells[0].Value);
                OperacionesAuto oa = new OperacionesAuto();
                oa.deleteAuto(idEliminar);
                LlenarData();
            }
        }
    }
}
