using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemopProductorConsumidor
{
    public class Pedidos
    {
        public int IdCliente { get; set; }
        public string NombreCliente { get; set; }
        public string DescripcionPedido { get; set; }
        public DateTime FechaCreacion { get; set; }
        public Pedidos(int idcliente, string nombrecliente, string descripcionpedido)
        {
            IdCliente = idcliente;
            NombreCliente = nombrecliente;
            DescripcionPedido = descripcionpedido;
            FechaCreacion = DateTime.Now;
        }

        public override string ToString()
        {
            return $"Id:{IdCliente}, NombreCliente:{NombreCliente}, DescripcionPedido:{DescripcionPedido}, Fecha:{FechaCreacion}";
        }
    }
}

