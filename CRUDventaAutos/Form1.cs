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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var agregarcompra = new AgregarCompra()) { agregarcompra.ShowDialog(); }
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var agregarVenta = new AgregarVenta()) { agregarVenta.ShowDialog(); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}