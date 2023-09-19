using CRUDventaAutos.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUDventaAutos.Utils;

namespace CRUDventaAutos
{
    public partial class AgregarVenta : Form
    {
        private int idVenta = 0;
        public AgregarVenta()
        {
            InitializeComponent();

        }

        private void Agregar_Click(object sender, EventArgs e)
        {
            OperacionesVenta ov = new OperacionesVenta();
            Venta venta = new Venta
            {
                fechaVenta = dtmFechaVenta.Value,
                id_Auto = Convert.ToInt32(txtIDauto.Text),
                id_Cliente = Convert.ToInt32(txtIDcliente.Text),
                TotalDeVenta = Convert.ToDecimal(txtTotal.Text)
            };

            ov.SaveVenta(venta);
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtIDauto.Text = "";
            txtIDcliente.Text = "";
            txtTotal.Text = "";
            dtmFechaVenta.Value = DateTime.Now;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OperacionesVenta ov = new OperacionesVenta();
            DataSet dsVenta = new DataSet();
            dsVenta = ov.GetVenta(int.Parse(txtIDVenta.Text));
            LLenarFormulario(dsVenta);
        }

        private void LLenarFormulario(DataSet dsVenta)
        {
            foreach (DataRow fila in dsVenta.Tables[0].Rows)
            {
                idVenta = Convert.ToInt16(fila["id_Venta"]);
                dtmFechaVenta.Value = Convert.ToDateTime(fila["fechaVenta"]);
                txtIDauto.Text = fila["idAutoVendido"].ToString();
                txtIDcliente.Text = fila["idCliente"].ToString();
                txtTotal.Text = fila["totalDeVenta"].ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            OperacionesVenta ov = new OperacionesVenta();
            Venta venta = new Venta
            {
                fechaVenta = dtmFechaVenta.Value,
                id_Auto = Convert.ToInt32(txtIDauto.Text),
                id_Cliente = Convert.ToInt32(txtIDcliente.Text),
                TotalDeVenta = Convert.ToDecimal(txtTotal.Text)
            };
            ov.UpdateVenta(venta, int.Parse(txtIDVenta.Text));
            LimpiarFormulario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperacionesVenta ov = new OperacionesVenta();
            ov.DeleteVenta(int.Parse(txtIDVenta.Text));
            LimpiarFormulario();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            OperacionesVenta ov = new OperacionesVenta();

            int id = ran.Next(3, 6);

            string archivo = ov.BuscarImagen(id);
            pictureBox1.ImageLocation = "C:\\Users\\Public\\Downloads\\" + archivo;

        }
    }
}
