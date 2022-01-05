using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviphone
{
    public class Movimientos
    {
        public string TipoPedido { get; set; }
        public string Articulo { get; set; }
        public string Cliente { get; set; }
        public string Proveedor { get; set; }
        public string Cantidad { get; set; }
        public string Fecha { get; set; }
        public int Entradas { get; set; }
        public int Salidas { get; set; }
        public int Existencia { get; set; }

        public Movimientos(string tipoPedido, string articulo, string cliente, string proveedor, string cantidad, string fecha,
                           int entradas, int salidas, int existencia)
        {
            TipoPedido = tipoPedido;
            Articulo = articulo;
            Cliente = cliente;
            Proveedor = proveedor;
            Cantidad = cantidad;
            Fecha = fecha;
            Entradas = entradas;
            Salidas = salidas;
            Existencia = existencia;
        }

        public Movimientos(string articulo, int existencia)
        {
            Articulo = articulo;
            Existencia = existencia;
        }

        public void DefinirExistencia(int existenciaactual)
        {
            Existencia = existenciaactual;
            return;
        }
    }
}
