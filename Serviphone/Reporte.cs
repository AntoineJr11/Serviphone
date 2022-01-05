using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serviphone
{
    public class Reporte
    {
        string Archivo;
        string tipoPedido;

        public int entrada, salida, existencia;

        public Reporte(string file, string TipoPedido)
        {
            Archivo = file;
            tipoPedido = TipoPedido;
        }

        public Reporte(string file)
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

        public List<Movimientos> GetMovimientos(string articulo) //crear lista para KARDEX
        {

            if (!File.Exists(Archivo))
            {
                return null;
            }

            try
            {
                List<Movimientos> movimientos = new List<Movimientos>();

                using (StreamReader srFile = new StreamReader(Archivo))
                {
                    string[] pedidoRegistro;
                    string strRegistro = string.Empty;

                    Movimientos movimiento;

                    while ((strRegistro = srFile.ReadLine()) != null)
                    {
                        pedidoRegistro = strRegistro.Split('|');

                        if (pedidoRegistro[1].Trim().Equals(articulo))
                        {
                            if (pedidoRegistro[0].Trim().Equals("COMPRA"))
                            {   
                                salida = 0;
                                entrada = int.Parse(pedidoRegistro[4]);
                                existencia += int.Parse(pedidoRegistro[4]);
                            }
                            else if(pedidoRegistro[0].Trim().Equals("VENTA"))
                            {
                                entrada = 0;
                                salida = int.Parse(pedidoRegistro[4]);
                                existencia -= int.Parse(pedidoRegistro[4]);
                            }
                            movimiento = new Movimientos(
                                pedidoRegistro[0],
                                pedidoRegistro[1],
                                pedidoRegistro[2],
                                pedidoRegistro[3],
                                pedidoRegistro[4],
                                pedidoRegistro[5],
                                entrada,
                                salida,
                                existencia
                                );

                            movimientos.Add(movimiento);
                        }
                    }
                }
                return movimientos;
            }

            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
