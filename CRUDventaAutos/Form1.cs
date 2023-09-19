using System.Data;
using System.Data.SqlClient;
using CRUDventaAutos.Utils;

namespace CRUDventaAutos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            LlenarData();
        }

        public void LlenarData()
        {
            DataSet ds = new DataSet();
            OperacionesVenta op = new OperacionesVenta();
            ds = op.GetAllVentas();
            BindingSource bs = new BindingSource();
            bs.DataSource = ds.Tables[0]; ;
            dataGridView1.DataSource = bs;
            dataGridView1.Refresh();
            dataGridView1.ReadOnly = true;
        }

        private void autosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var agregarAuto = new AgregarAutos()) { agregarAuto.ShowDialog(); }
        }



        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var agregarVenta = new AgregarVenta()) { agregarVenta.ShowDialog(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var result = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Eliminar registro", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DataGridViewRow row = dataGridView1.CurrentRow;
                int idEliminar = Convert.ToInt16(row.Cells[0].Value);
                OperacionesVenta op = new OperacionesVenta();
                op.DeleteVenta(idEliminar);
                LlenarData();
            }
        }

        private void autosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var buscarAuto = new BuscarAutos()) { buscarAuto.ShowDialog(); }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var buscarClientes = new BuscarCliente()) { buscarClientes.ShowDialog(); }
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (var buscarCompras = new BuscarCompra()) { buscarCompras.ShowDialog(); }
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var buscarProveedores = new BuscarProveedores()) { buscarProveedores.ShowDialog(); }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}