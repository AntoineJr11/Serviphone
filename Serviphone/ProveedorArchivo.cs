using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviphone
{
    class ProveedorArchivo
    {
        string ArchivoProveedor;
        string ArchivoProveedorTmp;
        string cadenaProveedor;

        public ProveedorArchivo(string file) //constructor archivo proveedor
        {
            ArchivoProveedor = file;
        }
        public ProveedorArchivo(string file, string tmp) //constructor para busqueda en archivos
        {
            ArchivoProveedor = file;
            ArchivoProveedorTmp = tmp;
        }
        public string AgregarProveedor(Proveedor proveedor)
        {
            using (StreamWriter srFile = new StreamWriter(ArchivoProveedor, true))
            {
                srFile.WriteLine($"{proveedor.NumeroIdentificacionProveedor}|{proveedor.NumeroFiscalProveedor}|" +
                    $"{proveedor.NombreProveedor}|{proveedor.ApellidoProveedor}|{proveedor.DireccionProveedor}|" +
                    $"{proveedor.CorreoElectronicoProveedor}|{proveedor.NumeroTelefonoProveedor}");
            }
            return "Se agrego el proveedor de forma correcta.";
        }
        public string BuscarProveedor(string numeroFiscalProveedor)
        {
            string nombreProveedor = "";

            using (StreamReader srFile = new StreamReader(ArchivoProveedor, true))
            {
                bool encontrado = true;
                string[] campos = new string[3];
                char[] separador = { '|' };

                cadenaProveedor = srFile.ReadLine();

                while (cadenaProveedor != null && encontrado == false)
                {
                    campos = cadenaProveedor.Split(separador);

                    if (campos[0].Trim().Equals(numeroFiscalProveedor))
                    {
                        nombreProveedor = cadenaProveedor;
                        encontrado = true;
                    }
                    else
                    {
                        cadenaProveedor = srFile.ReadLine();
                    }
                }
            }
            return nombreProveedor;
        }
        public List<Proveedor> GetProveedor() //crear lista de proveedor
        {
            if (!File.Exists(ArchivoProveedor))
            {
                return null;
            }

            try
            {

                List<Proveedor> proveedores = new List<Proveedor>();

                using (StreamReader srFile = new StreamReader(ArchivoProveedor))
                {
                    string[] proveedorRegistro;
                    string strRegistro = string.Empty;

                    Proveedor proveedor;

                    while ((strRegistro = srFile.ReadLine()) != null)
                    {
                        proveedorRegistro = strRegistro.Split('|');

                        proveedor = new Proveedor(
                            proveedorRegistro[0],
                            proveedorRegistro[1],
                            proveedorRegistro[2],
                            proveedorRegistro[3],
                            proveedorRegistro[4],
                            proveedorRegistro[5],
                            proveedorRegistro[6]
                            );

                        proveedores.Add(proveedor);
                    }
                }
                return proveedores;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string ModificarProveedor(Proveedor proveedor)//modificar registro en archivo
        {
            List<Proveedor> proveedores = GetProveedor();

            var proveedorModificar = proveedores.Find(p => p.NumeroFiscalProveedor == proveedor.NumeroFiscalProveedor);

            if (proveedorModificar == null)
            {
                return "El proveedor no existe.";
            }

            proveedores.Remove(proveedorModificar);
            proveedores.Add(proveedor);

            System.IO.File.WriteAllText(ArchivoProveedor, string.Empty);

            foreach (var item in proveedores)
            {
                AgregarProveedor(item);
            }

            return "Registro modificado correctamente.";
        }

        public string EliminarProveedor(string numeroFiscalProveedor)
        {
            List<Proveedor> proveedores = GetProveedor();
            Proveedor proveedor;
            proveedor = proveedores.Find(c => c.NumeroFiscalProveedor == numeroFiscalProveedor);

            if (proveedor == null)
            {
                return "El proveedor no existe";
            }

            proveedores.Remove(proveedor);

            File.WriteAllText(ArchivoProveedor, string.Empty);

            foreach (var provee in proveedores)
            {
                AgregarProveedor(provee);
            }

            return "Registro Eliminado Satisfactoriamente.";
        }

    }
}
