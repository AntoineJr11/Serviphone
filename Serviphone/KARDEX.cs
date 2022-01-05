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
    public partial class KARDEX : Form
    {
        Reporte kardex;

        public KARDEX()
        {
            InitializeComponent();

            txtBoxArticulo.Text = SELECTPRODUCTO.articulo;
            comboBoxStatus.Text = SELECTPRODUCTO.estatus;
            txtBoxPrecio.Text = SELECTPRODUCTO.precio;

            kardex = new Reporte("pedidos.txt");

            dataGridExistencia.DataSource = kardex.GetMovimientos(SELECTPRODUCTO.articulo);

            //int ultima = dataGridExistencia.Rows.Count - 1;
            //txtBoxCantidad.Text = dataGridKardex.Rows[ultima].Cells[8].Value.ToString();
            txtBoxCantidad.Text = Convert.ToString(kardex.existencia);
        }

        private void KARDEX_Load(object sender, EventArgs e)
        {

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            SELECTPRODUCTO ver = new SELECTPRODUCTO();
            ver.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtBoxId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridKardex_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
