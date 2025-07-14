using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteVentasDetComprobantesyProducto
    {
        public DateTime Fecha { get; set; }
        public string? Hora { get; set; }
        public int SucursalId { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public string TipoComprobante { get; set; } = null!;
        public string NumeroComprobante { get; set; } = null!;
        public string ModalidadDeCredito { get; set; } = null!;
        public int ClienteId { get; set; }
        public string ClienteNombre { get; set; } = null!;
        public string? ClienteLocalidad { get; set; }
        public string CodigoVendedor { get; set; } = null!;
        public string NombreVendedor { get; set; } = null!;
        public string? ProductoCodigo { get; set; }
        public string? ProductoDescripcion { get; set; }
        public string? ProductoDescripcionAbrev { get; set; }
        public string? ProductoMarca { get; set; }
        public decimal? CantidadVenta { get; set; }
        public decimal? PrecioUniSinIgv { get; set; }
        public decimal? PrecioUniConIgv { get; set; }
        public decimal? TotalSinIgv { get; set; }
        public decimal? TotalConIgv { get; set; }
    }
}
