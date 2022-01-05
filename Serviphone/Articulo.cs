using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviphone
{
    class Articulo
    {
        public int IdArticulo { get; set; }
        public string NombreArticulo { get; set; }
        public string MarcaArticulo { get; set; }
        public double Precio { get; set; }
        public string Estatus { get; set; }

        public Articulo(int idArticulo, string nombreArticulo, string marcaArticulo, double precio, string estatus)
        {
            IdArticulo = idArticulo;
            NombreArticulo = nombreArticulo;
            MarcaArticulo = marcaArticulo;
            Precio = precio;
            Estatus = estatus;
        }

    }
}
