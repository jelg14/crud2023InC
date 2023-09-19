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
    public partial class AgregarAutos : Form
    {
        public AgregarAutos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_Click(object sender, EventArgs e)
        {

        }

        public void button3_Click(object sender, EventArgs e)
        {
            OperacionesAuto oa = new OperacionesAuto();
            Auto auto = new Auto
            {
                marca = txtMarca.Text,
                modelo = txtModelo.Text,
                anio = txtAnio.Text,
                color = txtColor.Text,
                precio = Convert.ToDecimal(txtPrecio.Text),
                estado = cmbEstado.Text
            };

            oa.SaveAuto(auto);
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtAnio.Text = "";
            txtColor.Text = "";
            txtPrecio.Text = "";
            cmbEstado.Text = "";
            txtIDAuto.Text = "";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OperacionesAuto oa = new OperacionesAuto();
            DataSet dsAuto = new DataSet();
            dsAuto = oa.GetAuto(int.Parse(txtIDAuto.Text));
            LlenarFormulario(dsAuto);
        }

        private void LlenarFormulario(DataSet dsAuto)
        {
            foreach (DataRow dr in dsAuto.Tables[0].Rows)
            {
                txtMarca.Text = dr["marca"].ToString();
                txtModelo.Text = dr["modelo"].ToString();
                txtAnio.Text = dr["año"].ToString();
                txtColor.Text = dr["color"].ToString();
                txtPrecio.Text = dr["precio"].ToString();
                cmbEstado.Text = dr["estado"].ToString();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            OperacionesAuto oa = new OperacionesAuto();
            Auto auto = new Auto
            {
                marca = txtMarca.Text,
                modelo = txtModelo.Text,
                anio = txtAnio.Text,
                color = txtColor.Text,
                precio = Convert.ToDecimal(txtPrecio.Text),
                estado = cmbEstado.Text,
            };
            oa.updateAuto(auto, int.Parse(txtIDAuto.Text));
            LimpiarFormulario();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OperacionesAuto oa = new OperacionesAuto();
            oa.deleteAuto(int.Parse(txtIDAuto.Text));
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
