using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteVentasDetComprobantesyProductosMercaderium
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
        public string? Departamento { get; set; }
        public string? ClienteLocalidad { get; set; }
        public string? ProductoCodigo { get; set; }
        public string? CodigoInterno { get; set; }
        public string? ProductoDescripcion { get; set; }
        public string? ProductoDescripcionAbrev { get; set; }
        public string? ProductoMarca { get; set; }
        public decimal? CantidadVenta { get; set; }
        public decimal? PrecioUniSinIgv { get; set; }
        public decimal? PrecioUniConIgv { get; set; }
        public decimal? TotalSinIgvASoles { get; set; }
        public decimal? TotalConIgvASoles { get; set; }
        public decimal? TotalSinIgvADolares { get; set; }
        public decimal? TotalConIgvADolares { get; set; }
        public string? Vendedor { get; set; }
        public decimal? PrecioLista { get; set; }
    }
}
