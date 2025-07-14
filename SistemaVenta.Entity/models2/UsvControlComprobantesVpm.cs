using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvControlComprobantesVpm
    {
        public string PedidoNro { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string? PedidoFechaEmision { get; set; }
        public string? PedidoHoraEmision { get; set; }
        public string PedidoEstadoAprobacion { get; set; } = null!;
        public string? PedidoFechaAprobacion { get; set; }
        public string? PedidoHoraAprobacion { get; set; }
        public string? ClienteNombre { get; set; }
        public string VendedorNombre { get; set; } = null!;
        public string? ZonaReparto { get; set; }
        public string? FacturaNro { get; set; }
        public string? FacturaFechaEmision { get; set; }
        public string? FacturaHoraEmision { get; set; }
        public decimal? FacturaTotal { get; set; }
        public string? GuiaNro { get; set; }
        public string? GuiaFechaEmision { get; set; }
        public string? GuiaHoraEmision { get; set; }
        public string? ConsolidadoNro { get; set; }
        public string? ConsolidadoFechaEmision { get; set; }
        public string? ConsolidadoHoraEmision { get; set; }
    }
}
