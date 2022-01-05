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
    public partial class CLIENTES : Form
    {
        ClienteArchivo clientearc;
        ClienteArchivo clientetmp;
        Cliente cliente;

        public CLIENTES()
        {
            InitializeComponent();

            clientearc = new ClienteArchivo("clientes.txt");

            dataGridProd.DataSource = clientearc.GetClientes();

        }

        private void CLIENTES_Load(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxPrecio_TextChanged(object sender, EventArgs e)
        {

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

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;
            
            try
            {
                cliente = new Cliente(txtBoxNIT.Text, txtBoxDPI.Text, txtBoxNombre.Text,
                    txtBoxApellido.Text, txtBoxDireccion.Text, txtBoxCorreo.Text, txtBoxTelefono.Text);

                mensaje = clientearc.ModificarCliente(cliente);
                MessageBox.Show(mensaje);

                dataGridProd.DataSource = clientearc.GetClientes();

                txtBoxDPI.Clear();
                txtBoxNIT.Clear();
                txtBoxNombre.Clear();
                txtBoxApellido.Clear();
                txtBoxDireccion.Clear();
                txtBoxCorreo.Clear();
                txtBoxTelefono.Clear();

            }
            catch
            {

            }
        }

        private void txtBoxDPI_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNUEVO_Click(object sender, EventArgs e)
        {
            string mensaje;

            if (string.IsNullOrEmpty(txtBoxNIT.Text) || string.IsNullOrEmpty(txtBoxDPI.Text) ||
                string.IsNullOrEmpty(txtBoxNombre.Text) || string.IsNullOrEmpty(txtBoxApellido.Text) ||
                string.IsNullOrEmpty(txtBoxDireccion.Text) || string.IsNullOrEmpty(txtBoxCorreo.Text) ||
                string.IsNullOrEmpty(txtBoxTelefono.Text))
            {
                MessageBox.Show("Ingresar todos los valores del campo");
            }

            else
            {

                cliente = new Cliente(txtBoxNIT.Text, txtBoxDPI.Text, txtBoxNombre.Text,
                    txtBoxApellido.Text, txtBoxDireccion.Text, txtBoxCorreo.Text, txtBoxTelefono.Text);

                mensaje = clientearc.AgregarCliente(cliente);

                MessageBox.Show(mensaje);

                dataGridProd.DataSource = clientearc.GetClientes();

                txtBoxDPI.Clear();
                txtBoxNIT.Clear();
                txtBoxNombre.Clear();
                txtBoxApellido.Clear();
                txtBoxDireccion.Clear();
                txtBoxCorreo.Clear();
                txtBoxTelefono.Clear();
            }

        }

        private void buttonBorrar_Click(object sender, EventArgs e)
        {
            string mensaje;

            try
            {
                mensaje = clientearc.EliminarCliente(txtBoxNIT.Text);

                MessageBox.Show(mensaje);

                dataGridProd.DataSource = clientearc.GetClientes();

                txtBoxDPI.Clear();
                txtBoxNIT.Clear();
                txtBoxNombre.Clear();
                txtBoxApellido.Clear();
                txtBoxDireccion.Clear();
                txtBoxCorreo.Clear();
                txtBoxTelefono.Clear();
            }

            catch
            {

            }
        }

        private void buttonMODIFICAR_Click(object sender, EventArgs e)
        {
            txtBoxNIT.Text = Convert.ToString(dataGridProd.CurrentRow.Cells[0].Value);
            txtBoxDPI.Text = Convert.ToString(dataGridProd.CurrentRow.Cells[1].Value);
            txtBoxNombre.Text = Convert.ToString(dataGridProd.CurrentRow.Cells[2].Value);
            txtBoxApellido.Text = Convert.ToString(dataGridProd.CurrentRow.Cells[3].Value);
            txtBoxDireccion.Text = Convert.ToString(dataGridProd.CurrentRow.Cells[4].Value);
            txtBoxCorreo.Text = Convert.ToString(dataGridProd.CurrentRow.Cells[5].Value);
            txtBoxTelefono.Text = Convert.ToString(dataGridProd.CurrentRow.Cells[6].Value);

        }

        private void dataGridProd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
