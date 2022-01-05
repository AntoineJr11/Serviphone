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
    public partial class SELECTPRODUCTO : Form
    {
        public static string articulo = "";
        public static string precio = "";
        public static string estatus = "";

        public SELECTPRODUCTO()
        {
            InitializeComponent();

            using (StreamReader lector = new StreamReader("articulos.txt"))
            {
                while (lector.Peek() >= 0)
                {
                    comboBoxArticulo.Items.Add(lector.ReadLine().Split('|')[1]);
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        private void comboBoxArticulo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonKardex_Click(object sender, EventArgs e)
        {
            string cadena;
            string[] campos = new string[4];
            char[] separador = { '|' };
            bool encontrado = false;

            articulo = comboBoxArticulo.SelectedItem.ToString();

            using (StreamReader lector = new StreamReader("articulos.txt"))
            {
                while (lector.Peek() >= 0)
                {
                    comboBoxArticulo.Items.Add(lector.ReadLine().Split('|')[1]);
                }
            }

            StreamReader lector2 = new StreamReader("articulos.txt");

            cadena = lector2.ReadLine();

            while (cadena != null && encontrado == false)
            {
                campos = cadena.Split(separador);

                if (campos[1].Trim().Equals(articulo))
                {
                    estatus = campos[4].Trim();
                    precio = campos[3].Trim();
                    encontrado = true;
                }
                else
                {
                    cadena = lector2.ReadLine();
                }
            }

            this.Hide();
            KARDEX ver = new KARDEX();
            ver.Show();
        }

        private void SELECTPRODUCTO_Load(object sender, EventArgs e)
        {

        }
    }
}
