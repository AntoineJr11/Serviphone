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
    public partial class REPORTES : Form
    {
        public REPORTES()
        {
            InitializeComponent();
        }

        private void buttonClientes_Click(object sender, EventArgs e)
        {
            this.Hide();
            VENTAS ver = new VENTAS();
            ver.Show();
        }

        private void buttonPedidos_Click(object sender, EventArgs e)
        {
            this.Hide();
            EXISTENCIA ver = new EXISTENCIA();
            ver.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonKardex_Click(object sender, EventArgs e)
        {
            this.Hide();
            SELECTPRODUCTO ver = new SELECTPRODUCTO();
            ver.Show();
        }

        private void label21_Click(object sender, EventArgs e)
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

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            this.Hide();
            COMPRAS ver = new COMPRAS();
            ver.Show();
        }

        private void REPORTES_Load(object sender, EventArgs e)
        {

        }
    }
}
