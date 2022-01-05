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
    public partial class MENU : Form
    {
        public MENU()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void MENU_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            CLIENTES ver = new CLIENTES();
            ver.Show();
        }

        private void buttonProveedores_Click(object sender, EventArgs e)
        {
            this.Hide();
            PROVEEDORES ver = new PROVEEDORES();
            ver.Show();
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            PEDIDOS ver = new PEDIDOS();
            ver.Show();
        }

        private void buttonProductos_Click(object sender, EventArgs e)
        {
            this.Hide();
            PRODUCTOS ver = new PRODUCTOS();
            ver.Show();
        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            REPORTES ver = new REPORTES();
            ver.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
