using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvPedidoCabecera
    {
        public int PedidoId { get; set; }
        public string PedidoTdoc { get; set; } = null!;
        public string PedidoNro { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? PedidoFechaEmision { get; set; }
        public string? PedidoHoraEmision { get; set; }
        public string PedidoMoneda { get; set; } = null!;
        public decimal PedidoTotal { get; set; }
        public string PedidoEstadoAprobacion { get; set; } = null!;
        public string? PedidoFechaAprobacion { get; set; }
        public string? PedidoHoraAprobacion { get; set; }
        public string? ClienteNombre { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string VendedorCodigo { get; set; } = null!;
        public string VendedorNombre { get; set; } = null!;
        public string? ZonaReparto { get; set; }
    }
}
