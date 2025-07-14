using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteLibroRegistroVentasIngresosExportacionFinal
    {
        public string Periodo { get; set; } = null!;
        public string NumeroOperacion { get; set; } = null!;
        public string? NumeroCorrelativo { get; set; }
        public string? FechaEmision { get; set; }
        public string? FechaVencimiento { get; set; }
        public string TipoComprobantePago { get; set; } = null!;
        public string? Serie { get; set; }
        public string? NumCp { get; set; }
        public string Columna9 { get; set; } = null!;
        public string TipoDocumentoCliente { get; set; } = null!;
        public string DocIdentidad { get; set; } = null!;
        public string? Cliente { get; set; }
        public string? Columna13 { get; set; }
        public string? BaseImponible { get; set; }
        public string? Columna15 { get; set; }
        public string? ValorInafecto { get; set; }
        public string? Columna17 { get; set; }
        public string? MontoImpuesto { get; set; }
        public string? Columna19 { get; set; }
        public string? Columna20 { get; set; }
        public string? Columna21 { get; set; }
        public string? Total { get; set; }
        public string? TipoCambio { get; set; }
        public string? FechaEmisionOrigen { get; set; }
        public string? TipoComprobantePagoOrigen { get; set; }
        public string? SerieOrigen { get; set; }
        public string? NumCpOrigen { get; set; }
        public string Fob { get; set; } = null!;
        public int? Estado { get; set; }
        public string CampoLibre { get; set; } = null!;
        public int? Idperiodo { get; set; }
    }
}
