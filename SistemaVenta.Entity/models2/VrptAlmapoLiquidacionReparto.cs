using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptAlmapoLiquidacionReparto
    {
        public int SucursalId { get; set; }
        public string SucursalCodigo { get; set; } = null!;
        public string SucursalNombre { get; set; } = null!;
        public string SucursalDireccion { get; set; } = null!;
        public string? PuntoLlegada { get; set; }
        public DateTime ConsolidadoFecha { get; set; }
        public string ConsolidadoPlaca { get; set; } = null!;
        public string ConsolidadoNumero { get; set; } = null!;
        public string ChoferCodigo { get; set; } = null!;
        public string ChoferNombre { get; set; } = null!;
        public string Tipo { get; set; } = null!;
        public DateTime DetalleDocFechaEmision { get; set; }
        public string DetalleDocTipoCpCodigo { get; set; } = null!;
        public string DetalleDocNumCp { get; set; } = null!;
        public decimal DetalleDocTotal { get; set; }
        public int? DetalleDocZonaRepartoId { get; set; }
        public string? DetalleDocZonaRepartoCodigo { get; set; }
        public string? DetalleDocZonaRepartoNombre { get; set; }
        public int DetalleVendedorId { get; set; }
        public string DetalleVendedorCodigo { get; set; } = null!;
        public string DetalleVendedorNombre { get; set; } = null!;
    }
}
