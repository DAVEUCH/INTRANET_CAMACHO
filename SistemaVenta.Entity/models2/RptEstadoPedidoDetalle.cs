using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RptEstadoPedidoDetalle
    {
        public int PedidoId { get; set; }
        public string DetalleProductoCodigo { get; set; } = null!;
        public string DetalleProductoNombre { get; set; } = null!;
        public int DetalleProductoCantidadBase { get; set; }
        public string DetalleUnidad { get; set; } = null!;
        public int DetalleFactor { get; set; }
        public decimal BalanceEntrega { get; set; }
        public decimal BalanceFacturacion { get; set; }
    }
}
