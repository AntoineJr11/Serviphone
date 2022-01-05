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
    public partial class VENTAS : Form
    {
        Reporte archivoventa;

        public VENTAS()
        {
            InitializeComponent();
            archivoventa = new Reporte("pedidos.txt", "VENTA");

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

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonMOSTRAR_Click(object sender, EventArgs e)
        {
            dgvVentas.DataSource = archivoventa.GetPedido();
        }

        private void VENTAS_Load(object sender, EventArgs e)
        {

        }
    }
}
