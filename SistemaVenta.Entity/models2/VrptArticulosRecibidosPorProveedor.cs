using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptArticulosRecibidosPorProveedor
    {
        public int ComprobanteId { get; set; }
        public DateTime ComprobanteFechaEmision { get; set; }
        public string ComprobanteNumCp { get; set; } = null!;
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public int MonedaId { get; set; }
        public string MonedaDescripcion { get; set; } = null!;
        public string MonedaSimbolo { get; set; } = null!;
        public int PersonaId { get; set; }
        public string PersonaNombre { get; set; } = null!;
        public string ComprobanteEstadoEntrega { get; set; } = null!;
        public string ComprobanteEstadoFacturacion { get; set; } = null!;
        public decimal ItemCantidad { get; set; }
        public decimal ItemValorUnitario { get; set; }
        public decimal ItemTotalIncluidoImpuesto { get; set; }
        public int? ItemCantidadBase { get; set; }
        public int? ItemFactor { get; set; }
        public string? ItemUnidadAbreviacion { get; set; }
        public string? ItemProductoCodigo { get; set; }
        public string? ItemProductoDescripcion { get; set; }
        public decimal ItemBalanceEntrega { get; set; }
        public decimal ItemBalanceFacturacion { get; set; }
        public decimal ItemCantidadAentregar { get; set; }
        public DateTime? FechaEntrega { get; set; }
    }
}
