using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviphone
{
    public class Pedido
    {
        public string TipoPedido { get; set; }
        public string Articulo { get; set; }
        public string Cliente { get; set; }
        public string Proveedor { get; set; }
        public string Cantidad { get; set; }
        public string Fecha { get; set; }

        public Pedido(string tipoPedido, string articulo, string cliente, string proveedor, string cantidad, string fecha)
        {
            TipoPedido = tipoPedido;
            Articulo = articulo;
            Cliente = cliente;
            Proveedor = proveedor;
            Cantidad = cantidad;
            Fecha = fecha;
        }
    }
}
