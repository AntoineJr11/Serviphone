using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace Serviphone
{
    class ArticuloArchivo
    {
        string ArchivoArticulo;
        string cadenaArticulo;

        public ArticuloArchivo(string file) //Constructor para el archivo de articulos
        {
            ArchivoArticulo = file;
        }

        public string AgregarArticulo(Articulo articulo)
        {
            using (StreamWriter srFile = new StreamWriter(ArchivoArticulo, true))
            {
                srFile.WriteLine($"{articulo.IdArticulo}|{articulo.NombreArticulo}|{articulo.MarcaArticulo}|{articulo.Precio}|{articulo.Estatus}");
            }
            return "Se agrego correctamente el producto";
        }

        public string BuscarArticulo(string idarticulo) //Buscar en el archivo el articulo
        {
            string nombrearticulo = "";

            using (StreamReader srFile = new StreamReader(ArchivoArticulo, true))
            {
                bool encontrado = true;
                string[] campos = new string[3];
                char[] separador = { '|' };

                cadenaArticulo = srFile.ReadLine();

                while (cadenaArticulo != null && encontrado == false)
                {
                    campos = cadenaArticulo.Split(separador);

                    if (campos[0].Trim().Equals(idarticulo))
                    {
                        nombrearticulo = cadenaArticulo;
                        encontrado = true;
                    }
                    else
                    {
                        cadenaArticulo = srFile.ReadLine();
                    }
                }
            }
            return nombrearticulo;
        }
        public List<Articulo> GetArticulos() //crear lista de articulos
        {
            if (!File.Exists(ArchivoArticulo))
            {
                return null;
            }

            try
            {
                List<Articulo> articulos = new List<Articulo>();

                using (StreamReader srFile = new StreamReader(ArchivoArticulo))
                {
                    string[] articuloRegistro;
                    string strRegistro = string.Empty;

                    Articulo articulo;

                    while ((strRegistro = srFile.ReadLine()) != null)
                    {
                        articuloRegistro = strRegistro.Split('|');

                        articulo = new Articulo(
                            int.Parse(articuloRegistro[0]),
                            articuloRegistro[1],
                            articuloRegistro[2],
                            double.Parse(articuloRegistro[3]),
                            articuloRegistro[4]
                            );

                        articulos.Add(articulo);
                    }
                }
                return articulos;

            }

            catch (Exception ar)
            {
                throw ar;
            }
        }

        public string ModificarArticulo(Articulo articulo)//modificar registro en archivo
        {
            List<Articulo> articulos = GetArticulos();

            var articuloModificar = articulos.Find(a => a.IdArticulo == articulo.IdArticulo);

            if (articuloModificar == null)
            {
                return "El producto no existe.";
            }

            articulos.Remove(articuloModificar);
            articulos.Add(articulo);

            System.IO.File.WriteAllText(ArchivoArticulo, string.Empty);

            foreach (var item in articulos)
            {
                AgregarArticulo(item);
            }

            return "Registro modificado correctamente.";
        }

        public string EliminarArticulo(int idarticulo)
        {
            List<Articulo> articulos = GetArticulos();
            Articulo articulo;
            articulo = articulos.Find(a => a.IdArticulo == idarticulo);

            if (articulo == null)
            {
                return "El producto no existe";
            }

            articulos.Remove(articulo);

            File.WriteAllText(ArchivoArticulo, string.Empty);

            foreach (var article in articulos)
            {
                AgregarArticulo(article);
            }

            return "Registro Eliminado Satisfactoriamente";
        }
    }
}
