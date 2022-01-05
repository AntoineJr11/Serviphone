using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviphone
{
    public class ClienteArchivo
    {
        string ArchivoCliente;
        string cadenaCliente;

        public ClienteArchivo(string file) //constructor archivo clientes
        {
            ArchivoCliente = file;
        }

        public string AgregarCliente(Cliente cliente)
        {
            using (StreamWriter srFile = new StreamWriter(ArchivoCliente, true))
            {
                srFile.WriteLine($"{cliente.NumeroIdentificacionCliente}|{cliente.NumeroFiscalCliente}|{cliente.NombreCliente}|" +
                    $"{cliente.ApellidoCliente}|{cliente.DireccionCliente}|{cliente.CorreoElectronicoCliente}|{cliente.NumeroTelefonoCliente}");
            }
            return "Se agrego el cliente de forma correcta.";
        }
        public string BuscarCliente(string idcliente)
        {
            string nombreCliente = "";

            using (StreamReader srFile = new StreamReader(ArchivoCliente, true))
            {
                bool encontrado = true;
                string[] campos = new string[3];
                char[] separador = { '|' };

                cadenaCliente = srFile.ReadLine();

                while (cadenaCliente != null && encontrado == false)
                {
                    campos = cadenaCliente.Split(separador);

                    if (campos[0].Trim().Equals(idcliente))
                    {
                        nombreCliente = cadenaCliente;
                        encontrado = true;
                    }
                    else
                    {
                        cadenaCliente = srFile.ReadLine();
                    }
                }
            }
            return nombreCliente;
        }
        public List<Cliente> GetClientes() //crear lista de clientes
        {
            if (!File.Exists(ArchivoCliente))
            {
                return null;
            }

            try
            {
                List<Cliente> clientes = new List<Cliente>();

                using (StreamReader srFile = new StreamReader(ArchivoCliente))
                {
                    string[] clientesRegistro;
                    string strRegistro = string.Empty;

                    Cliente cliente;

                    while ((strRegistro = srFile.ReadLine()) != null)
                    {
                        clientesRegistro = strRegistro.Split('|');

                        cliente = new Cliente(
                            clientesRegistro[0],
                            clientesRegistro[1],
                            clientesRegistro[2],
                            clientesRegistro[3],
                            clientesRegistro[4],
                            clientesRegistro[5],
                            clientesRegistro[6]
                            );

                        clientes.Add(cliente);
                    }
                }
                return clientes;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ModificarCliente(Cliente cliente) //modificar cliente
        {
            List<Cliente> clientes = GetClientes();

            var clienteModificar = clientes.Find(c => c.NumeroFiscalCliente == cliente.NumeroFiscalCliente);

            if (clienteModificar == null)
            {
                return "El registro no existe.";
            }

            clientes.Remove(clienteModificar);
            clientes.Add(cliente);

            System.IO.File.WriteAllText(ArchivoCliente, string.Empty);

            foreach (var item in clientes)
            {
                AgregarCliente(item);
            }

            return "Registro modificado correctamente.";
        }

        public string EliminarCliente(string numeroFiscalCliente)
        {
            List<Cliente> clientes = GetClientes();
            Cliente cliente;
            cliente = clientes.Find(c => c.NumeroFiscalCliente == numeroFiscalCliente);

            if (cliente == null)
            {
                return "El cliente no existe";
            }

            clientes.Remove(cliente);

            File.WriteAllText(ArchivoCliente, string.Empty);

            foreach (var client in clientes)
            {
                AgregarCliente(client);
            }

            return "Registro Eliminado Satisfactoriamente.";
        }

    }
}
