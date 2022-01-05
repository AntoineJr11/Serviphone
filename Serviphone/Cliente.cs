using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Serviphone
{
    public class Cliente
    {
        //public int IdPersona { get; set; }
        public string NumeroFiscalCliente { get; set; }
        public string NumeroIdentificacionCliente { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidoCliente { get; set; }
        public string DireccionCliente { get; set; }
        public string CorreoElectronicoCliente { get; set; }
        public string NumeroTelefonoCliente { get; set; }

        public PedidoArchivo[] pedido;


        public Cliente(string numeroFiscalCliente, string numeroIdentificacionCliente, string nombreCliente,
               string apellidoCliente, string direccionCliente, string correoElectronicoCliente, string numeroTelefonoCliente)
        {
            NumeroFiscalCliente = numeroFiscalCliente;
            NumeroIdentificacionCliente = numeroIdentificacionCliente;
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            DireccionCliente = direccionCliente;
            CorreoElectronicoCliente = correoElectronicoCliente;
            NumeroTelefonoCliente = numeroTelefonoCliente;
        }

        public Cliente(string numeroFiscalCliente, string nombreCliente, string apellidoCliente,
            string direccionCliente)
        {
            NumeroFiscalCliente = numeroFiscalCliente;
            NombreCliente = nombreCliente;
            ApellidoCliente = apellidoCliente;
            DireccionCliente = direccionCliente;
        }

    }
}
