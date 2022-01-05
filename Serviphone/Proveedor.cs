using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviphone
{
    public class Proveedor
    {
        //public int IdPersona { get; set; }
        public string NumeroFiscalProveedor { get; set; }
        public string NumeroIdentificacionProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string ApellidoProveedor { get; set; }
        public string DireccionProveedor { get; set; }
        public string CorreoElectronicoProveedor { get; set; }
        public string NumeroTelefonoProveedor { get; set; }

        public PedidoArchivo[] pedido;
 
        //Crear objeto para arreglo

        public Proveedor(string numeroFiscalProveedor, string numeroIdentificacionProveedor, string nombreProveedor,
            string apellidoProveedor, string direccionProveedor, string correoElectronicoProveedor, string numeroTelefonoProveedor)
        {
            NumeroFiscalProveedor = numeroFiscalProveedor;
            NumeroIdentificacionProveedor = numeroIdentificacionProveedor;
            NombreProveedor = nombreProveedor;
            ApellidoProveedor = apellidoProveedor;
            DireccionProveedor = direccionProveedor;
            CorreoElectronicoProveedor = correoElectronicoProveedor;
            NumeroTelefonoProveedor = numeroTelefonoProveedor;
        }

    }
}
