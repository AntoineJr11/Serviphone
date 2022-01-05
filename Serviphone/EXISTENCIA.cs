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
    public partial class EXISTENCIA : Form
    {
        Reporte reporteexistencia;

        public EXISTENCIA()
        {
            InitializeComponent();

            reporteexistencia = new Reporte("pedidos.txt");

            string cadena;
            string inventario;
            string[] campos = new string[5];
            char[] separador = { '|' };

            StreamReader existencia = new StreamReader("articulos.txt");

            while ((cadena = existencia.ReadLine()) != null)
            {
                campos = cadena.Split(separador);

                dataGridViewExistencia.Columns[0].HeaderText = "ID";
                dataGridViewExistencia.Columns[1].HeaderText = "NOMBRE";
                dataGridViewExistencia.Columns[2].HeaderText = "MARCA";
                dataGridViewExistencia.Columns[3].HeaderText = "PRECIO";
                dataGridViewExistencia.Columns[4].HeaderText = "ESTATUS";
                dataGridViewExistencia.Columns[5].HeaderText = "EXISTENCIA";

                dataGridViewMov.DataSource = reporteexistencia.GetMovimientos(Convert.ToString(campos[1]));

                inventario = Convert.ToString(reporteexistencia.existencia);

                dataGridViewExistencia.Rows.Add(campos[0], campos[1], campos[2], campos[3], campos[4], inventario);

                inventario = "0";

            }

        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            REPORTES ver = new REPORTES();
            ver.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
