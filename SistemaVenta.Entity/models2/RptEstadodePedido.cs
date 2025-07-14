using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RptEstadodePedido
    {
        public int Idgrupo { get; set; }
        public string TipoCp { get; set; } = null!;
        public int Orden { get; set; }
        public int PedidoId { get; set; }
        public string PedidoDoc { get; set; } = null!;
        public string PedidoNumero { get; set; } = null!;
        public DateTime PedidoFecha { get; set; }
        public DateTime PedidoFechaEntrega { get; set; }
        public decimal PedidoTotal { get; set; }
        public string Moneda { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public string ClienteTipoDocumento { get; set; } = null!;
        public string ClienteDocIdentidad { get; set; } = null!;
        public string DetalleProductoCodigo { get; set; } = null!;
        public string DetalleProductoNombre { get; set; } = null!;
        public int DetalleProductoCantidadBase { get; set; }
        public string DetalleUnidad { get; set; } = null!;
        public int DetalleFactor { get; set; }
        public decimal BalanceEntrega { get; set; }
        public decimal BalanceFacturacion { get; set; }
        public string EstadoEntrega { get; set; } = null!;
        public string EstadoFacturacion { get; set; } = null!;
    }
}
