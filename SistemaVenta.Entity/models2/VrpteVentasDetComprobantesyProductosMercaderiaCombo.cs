using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteVentasDetComprobantesyProductosMercaderiaCombo
    {
        public DateTime Fecha { get; set; }
        public string? Hora { get; set; }
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string TipoComprobante { get; set; } = null!;
        public string NumeroComprobante { get; set; } = null!;
        public string ClienteNombre { get; set; } = null!;
        public string? ProductoCodigoPadre { get; set; }
        public string? CodigoInternoPadre { get; set; }
        public bool? EsAgrupacion { get; set; }
        public string? ProductoDescripcionPadre { get; set; }
        public string? ProductoDescripcionAbrev { get; set; }
        public string? ProductoCodigoHijo { get; set; }
        public string? ProductoDescripcionHijo { get; set; }
        public string? ProductoMarca { get; set; }
        public decimal? CantidadVenta { get; set; }
        public decimal? PrecioUniSinIgv { get; set; }
        public decimal? PrecioUniConIgv { get; set; }
        public decimal? TotalSinIgvASoles { get; set; }
        public decimal? TotalConIgvASoles { get; set; }
    }
}
