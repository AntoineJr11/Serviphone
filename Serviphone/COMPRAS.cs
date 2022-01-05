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
    public partial class COMPRAS : Form
    {
        Reporte archivoventas;

        public COMPRAS()
        {
            InitializeComponent();
            archivoventas = new Reporte("pedidos.txt", "COMPRA");

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
            REPORTES ver = new REPORTES();
            ver.Show();
        }

        private void buttonMOSTRAR_Click(object sender, EventArgs e)
        {
            dgvCompras.DataSource = archivoventas.GetPedido();
        }

        private void dgvCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
