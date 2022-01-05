using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Serviphone
{
    public partial class PEDIDOS : Form
    {
        PedidoArchivo pedidoarc;
        Pedido pedido;
        public PEDIDOS()
        {
            InitializeComponent();

            pedidoarc = new PedidoArchivo("pedidos.txt");

            dataGridPedido.DataSource = pedidoarc.GetPedido();

            using (StreamReader lector = new StreamReader("articulos.txt"))
            {
                while (lector.Peek() >= 0)
                {
                    comboBoxArticulo.Items.Add(lector.ReadLine().Split('|')[1]);
                }
            }

            using (StreamReader lector = new StreamReader("clientes.txt"))
            {
                while (lector.Peek() >= 0)
                {
                    comboBoxCliente.Items.Add(lector.ReadLine().Split('|')[1]);
                }
            }

            using (StreamReader lector = new StreamReader("proveedores.txt"))
            {
                while (lector.Peek() >= 0)
                {
                    comboBoxProveedor.Items.Add(lector.ReadLine().Split('|')[1]);
                }
            }

        }

        private void PEDIDOS_Load(object sender, EventArgs e)
        {

        }

        private void comboBoxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTipo.SelectedItem.ToString() == "VENTA")
            {
                comboBoxCliente.Enabled = true;
                comboBoxProveedor.Enabled = false;
            }
            else if (comboBoxTipo.SelectedItem.ToString() == "COMPRA")
            {
                comboBoxCliente.Enabled = false;
                comboBoxProveedor.Enabled = true;
            }
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            MENU ver = new MENU();
            ver.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBoxArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            comboBoxTipo.Text = Convert.ToString(dataGridPedido.CurrentRow.Cells[0].Value);
            comboBoxArticulo.Text = Convert.ToString(dataGridPedido.CurrentRow.Cells[1].Value);
            comboBoxCliente.Text = Convert.ToString(dataGridPedido.CurrentRow.Cells[2].Value);
            comboBoxProveedor.Text = Convert.ToString(dataGridPedido.CurrentRow.Cells[3].Value);
            txtBoxCantidad.Text = Convert.ToString(dataGridPedido.CurrentRow.Cells[4].Value);
            dateFecha.Text = Convert.ToString(dataGridPedido.CurrentRow.Cells[5].Value);

        }

        private void buttonNUEVO_Click(object sender, EventArgs e)
        {
            string mensaje;
            string fecha;

            if (Convert.ToDateTime(dateFecha.Text) < DateTime.Now.Date)
            {
                MessageBox.Show("Fecha menor a la fecha actual");
            }

            else
            {
                fecha = dateFecha.Value.Date.ToShortDateString();

                pedido = new Pedido(comboBoxTipo.Text, comboBoxArticulo.Text, comboBoxCliente.Text,
                    comboBoxProveedor.Text, txtBoxCantidad.Text, fecha);

                mensaje = pedidoarc.AgregarPedido(pedido);

                MessageBox.Show(mensaje);

                dataGridPedido.DataSource = pedidoarc.GetPedido();
            }

            comboBoxTipo.ResetText();
            comboBoxArticulo.ResetText();
            comboBoxCliente.ResetText();
            comboBoxProveedor.ResetText();
            txtBoxCantidad.Clear();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtBoxCantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonMODIFICAR_Click(object sender, EventArgs e)
        {
            comboBoxTipo.Text = Convert.ToString(dataGridPedido.CurrentRow.Cells[0].Value);
            comboBoxArticulo.Text = Convert.ToString(dataGridPedido.CurrentRow.Cells[1].Value);
            comboBoxCliente.Text = Convert.ToString(dataGridPedido.CurrentRow.Cells[2].Value);
            comboBoxProveedor.Text = Convert.ToString(dataGridPedido.CurrentRow.Cells[3].Value);
            txtBoxCantidad.Text = Convert.ToString(dataGridPedido.CurrentRow.Cells[4].Value);
            dateFecha.Text = Convert.ToString(dataGridPedido.CurrentRow.Cells[5].Value);

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string mensaje;
            string fecha;

            try
            {
                fecha = dateFecha.Value.Date.ToShortDateString();

                pedido = new Pedido(comboBoxTipo.Text, comboBoxArticulo.Text, comboBoxCliente.Text,
                comboBoxProveedor.Text, txtBoxCantidad.Text, fecha);

                mensaje = pedidoarc.ModificarPedido(pedido);
                MessageBox.Show(mensaje);

                dataGridPedido.DataSource = pedidoarc.GetPedido();

                comboBoxTipo.ResetText();
                comboBoxArticulo.ResetText();
                comboBoxCliente.ResetText();
                comboBoxProveedor.ResetText();
                txtBoxCantidad.Clear();

            }
            catch
            {

            }
        }

        private void dateFecha_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
