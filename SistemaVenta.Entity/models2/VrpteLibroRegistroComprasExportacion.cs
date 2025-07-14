using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteLibroRegistroComprasExportacion
    {
        public string Periodo { get; set; } = null!;
        public string NumeroOperacion { get; set; } = null!;
        public string? FechaEmision { get; set; }
        public string? FechaVencimiento { get; set; }
        public string TipoComprobantePago { get; set; } = null!;
        public string? Serie { get; set; }
        public int? AñoDua { get; set; }
        public string? NumCp { get; set; }
        public string Columna9 { get; set; } = null!;
        public string TipoDocumentoProveedor { get; set; } = null!;
        public string? DocIdentidad { get; set; }
        public string? Proveedor { get; set; }
        public string? BaseImponible1 { get; set; }
        public string? MontoImpuesto1 { get; set; }
        public string? BaseImponible2 { get; set; }
        public string? MontoImpuesto2 { get; set; }
        public string? BaseImponible3 { get; set; }
        public string? MontoImpuesto3 { get; set; }
        public string? ValorInafecto { get; set; }
        public string? Columna20 { get; set; }
        public string? Columna21 { get; set; }
        public string? Total { get; set; }
        public string? TipoCambioFecha { get; set; }
        public string? FechaEmisionOrigen { get; set; }
        public string? TipoComprobantePagoOrigen { get; set; }
        public string? SerieOrigen { get; set; }
        public string? NumCpOrigen { get; set; }
        public string Columna28 { get; set; } = null!;
        public string FechaEmisionComprobanteDetraccion { get; set; } = null!;
        public string NumCpComprobanteDetraccion { get; set; } = null!;
        public int Columna31 { get; set; }
        public int? Estado { get; set; }
        public string CampoLibre { get; set; } = null!;
        public int Idperiodo { get; set; }
    }
}
