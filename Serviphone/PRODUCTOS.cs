using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serviphone
{
    public partial class PRODUCTOS : Form
    {
        ArticuloArchivo articulosarc;
        Articulo articulo;

        String status;

        public PRODUCTOS()
        {
            InitializeComponent();

            articulosarc = new ArticuloArchivo("articulos.txt");

            dataGridProd.DataSource = articulosarc.GetArticulos();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MENU ver = new MENU();
            ver.Show();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;

            switch (comboBoxStatus.SelectedIndex)
            {
                case 0:
                    status = "Activo";
                    break;

                case 1:
                    status = "Inactivo";
                    break;
            }

            try
            {
                articulo = new Articulo(int.Parse(txtBoxId.Text), txtBoxNombre.Text, txtBoxMarca.Text, 
                    double.Parse(txtBoxPrecio.Text), status);

                mensaje = articulosarc.ModificarArticulo(articulo);

                MessageBox.Show(mensaje);

                dataGridProd.DataSource = articulosarc.GetArticulos();

                txtBoxId.Clear();
                txtBoxNombre.Clear();
                txtBoxPrecio.Clear();
                txtBoxMarca.Clear();
                comboBoxStatus.DataSource = null;

            }

            catch
            {

            }
        }

        private void dataGridProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonMODIFICAR_Click(object sender, EventArgs e)
        { 
            txtBoxId.Text = Convert.ToString(dataGridProd.CurrentRow.Cells[0].Value);
            txtBoxNombre.Text = Convert.ToString(dataGridProd.CurrentRow.Cells[1].Value);
            txtBoxMarca.Text = Convert.ToString(dataGridProd.CurrentRow.Cells[2].Value);
            txtBoxPrecio.Text = Convert.ToString(dataGridProd.CurrentRow.Cells[3].Value);
            comboBoxStatus.Text = Convert.ToString(dataGridProd.CurrentRow.Cells[4].Value);
        }

        private void txtBoxId_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttonNUEVO_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (string.IsNullOrEmpty(txtBoxId.Text) || string.IsNullOrEmpty(txtBoxNombre.Text) ||
                string.IsNullOrEmpty(txtBoxPrecio.Text) || string.IsNullOrEmpty(txtBoxMarca.Text))
            {
                MessageBox.Show("Ingresar todos los valores del campo");
            }

            else
            {

                switch (comboBoxStatus.SelectedIndex)
                {
                    case 0:
                        status = "Activo";
                        break;

                    case 1:
                        status = "Inactivo";
                        break;
                }

                articulo = new Articulo(int.Parse(txtBoxId.Text), txtBoxNombre.Text, txtBoxMarca.Text, double.Parse(txtBoxPrecio.Text), status);

                mensaje = articulosarc.AgregarArticulo(articulo);

                MessageBox.Show(mensaje);

                dataGridProd.DataSource = articulosarc.GetArticulos();

                txtBoxId.Clear();
                txtBoxNombre.Clear();
                txtBoxMarca.Clear();
                txtBoxPrecio.Clear();
                comboBoxStatus.ResetText();
            }

        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            string mensaje;

            try
            {
                mensaje = articulosarc.EliminarArticulo(int.Parse(txtBoxId.Text));

                MessageBox.Show(mensaje);

                dataGridProd.DataSource = articulosarc.GetArticulos();

                txtBoxId.Clear();
                txtBoxNombre.Clear();
                txtBoxMarca.Clear();
                txtBoxPrecio.Clear();
                comboBoxStatus.DataSource = null;
            }

            catch
            {

            }
        }

        private void PRODUCTOS_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }
    }
}
