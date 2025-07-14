using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvPedidoClienteyTransporte
    {
        public int Pkidpedido { get; set; }
        public string NumeroPedido { get; set; } = null!;
        public DateTime FechaPedido { get; set; }
        public bool PedidoAnulado { get; set; }
        public int Idcliente { get; set; }
        public string? NombreCliente { get; set; }
        public string DirecCliente { get; set; } = null!;
        public int? IdclienteEntrega { get; set; }
        public string DireccionEntrega { get; set; } = null!;
        public string? NombreAgenTransp { get; set; }
        public int EsAgenciatransporte { get; set; }
        public bool Anulado { get; set; }
    }
}
