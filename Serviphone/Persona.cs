using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviphone
{
    public class Persona
    {
        //public int IdPersona { get; set; }
        public string NumeroFiscal { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string NombrePersona { get; set; }
        public string ApellidoPersona { get; set; }
        public string Direccion { get; set; }
        public string CorreoElectronico { get; set; }
        public string NumeroTelefono { get; set; }

        public Cliente[] cliente;

        public Proveedor[] proveedor;

        public Persona(string numeroFiscal, string numeroIdentificacion, string nombrePersona,
            string apellidoPersona, string direccion, string correoElectronico, string numeroTelefono)
        {
            NumeroFiscal = numeroFiscal;
            NumeroIdentificacion = numeroIdentificacion;
            NombrePersona = nombrePersona;
            ApellidoPersona = apellidoPersona;
            Direccion = direccion;
            CorreoElectronico = correoElectronico;
            NumeroTelefono = numeroTelefono;
        }
    }
}
