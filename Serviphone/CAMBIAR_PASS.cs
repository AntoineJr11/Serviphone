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
    public partial class CAMBIAR_PASS : Form
    {
        public CAMBIAR_PASS()
        {
            InitializeComponent();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtBoxAnterior.UseSystemPasswordChar == false && txtBoxNueva.UseSystemPasswordChar == false)
            {
                txtBoxAnterior.UseSystemPasswordChar = true;
                txtBoxNueva.UseSystemPasswordChar = true;
            }
            else
            {
                txtBoxAnterior.UseSystemPasswordChar = false;
                txtBoxNueva.UseSystemPasswordChar = false;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            StreamReader lectura;
            StreamWriter escribir;
            string cadena, vieja, nueva;
            bool encontrado = false;
            string[] campos = new string[17];
            char[] separador = { '|' };

            try
            {
                lectura = File.OpenText("credenciales.txt");
                escribir = File.CreateText("temporal.txt");

                vieja = txtBoxAnterior.Text;
                nueva = txtBoxNueva.Text;
                cadena = lectura.ReadLine();

                while (cadena != null)
                {
                    campos = cadena.Split(separador);
                    if (campos[1].Trim().Equals(vieja))
                    {
                        encontrado = true;
                        escribir.WriteLine(string.Format("{0}|{1}", campos[0], nueva));

                        MessageBox.Show("Contraseña Cambiada");
                    }
                    else
                    {
                        escribir.WriteLine(cadena);
                    }

                    cadena = lectura.ReadLine();
                }

                if (encontrado == false)
                {
                    MessageBox.Show("Contraseña Invalida");
                }


                lectura.Close();
                escribir.Close();

                File.Delete("credenciales.txt");
                File.Move("temporal.txt",
                    "credenciales.txt");
            }

            catch (FileNotFoundException fe)
            {
                MessageBox.Show("Error" + fe.Message);
            }
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            INGRESO ver = new INGRESO();
            ver.Show();
        }

        private void CAMBIAR_PASS_Load(object sender, EventArgs e)
        {

        }
    }
}
