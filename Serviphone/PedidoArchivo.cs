using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviphone
{
    public class PedidoArchivo
    {
        string ArchivoPedido;
        string ArchivoPedidoTmp;
        string cadenaPedido;
        string nombreart;

        public PedidoArchivo(string file) //constructor archivo pedidos
        {
            ArchivoPedido = file;
        }
        public PedidoArchivo(string file, string tmp) //para modificar datos 
        {
            ArchivoPedido = file;
        }

        public string AgregarPedido(Pedido pedido)
        {
            using (StreamWriter srFile = new StreamWriter(ArchivoPedido, true))
            {
                srFile.WriteLine($"{pedido.TipoPedido}|{pedido.Articulo}|{pedido.Cliente}|{pedido.Proveedor}|{pedido.Cantidad}|{pedido.Fecha}");
            }
            return "Se agrego el pedido de forma correcta.";
        }

        public List<Pedido> GetPedido() //crear lista para pedidos
        {
            if (!File.Exists(ArchivoPedido))
            {
                return null;
            }

            try
            {
                List<Pedido> pedidos = new List<Pedido>();

                using (StreamReader srFile = new StreamReader(ArchivoPedido))
                {
                    string[] pedidoRegistro;
                    string strRegistro = string.Empty;

                    Pedido pedido;

                    while ((strRegistro = srFile.ReadLine()) != null)
                    {
                        pedidoRegistro = strRegistro.Split('|');

                        pedido = new Pedido(
                            pedidoRegistro[0],
                            pedidoRegistro[1],
                            pedidoRegistro[2],
                            pedidoRegistro[3],
                            pedidoRegistro[4],
                            pedidoRegistro[5]
                            );

                        pedidos.Add(pedido);
                    }
                }
                return pedidos;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string ModificarPedido(Pedido pedido) //modificar cliente
        {
            List<Pedido> pedidos = GetPedido();

            var pedidoModificar = pedidos.Find(c => c.Articulo == pedido.Articulo);

            if (pedidoModificar == null)
            {
                return "El registro no existe.";
            }

            pedidos.Remove(pedidoModificar);
            pedidos.Add(pedido);

            System.IO.File.WriteAllText(ArchivoPedido, string.Empty);

            foreach (var item in pedidos)
            {
                AgregarPedido(item);
            }

            return "Registro modificado correctamente.";
        }
    }
}