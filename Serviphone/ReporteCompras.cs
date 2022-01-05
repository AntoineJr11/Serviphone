using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Serviphone
{
    class ReporteCompras
    {
        string Archivo;
        string tipoPedido = "COMPRA";

        public ReporteCompras(string file)
        {
            Archivo = file;
        }

        public List<Pedido> GetPedido() //crear lista para pedidos
        {
            if (!File.Exists(Archivo))
            {
                return null;
            }

            try
            {
                List<Pedido> pedidos = new List<Pedido>();

                using (StreamReader srFile = new StreamReader(Archivo))
                {
                    string[] pedidoRegistro;
                    string strRegistro = string.Empty;

                    Pedido pedido;

                    while ((strRegistro = srFile.ReadLine()) != null)
                    {
                        pedidoRegistro = strRegistro.Split('|');

                        if (pedidoRegistro[0].Trim().Equals(tipoPedido))
                        {

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
                }
                return pedidos;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
