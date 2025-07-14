using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteLibroRegistroInventarioPermanenteValorizadoExportacion
    {
        public string Periodo { get; set; } = null!;
        public string Columna2 { get; set; } = null!;
        public string CodigoCatalogo { get; set; } = null!;
        public string TipoExistencia { get; set; } = null!;
        public string? CodigoExistencia { get; set; }
        public string? ComprobanteFechaEmision { get; set; }
        public string TipoDocumento { get; set; } = null!;
        public string? Serie { get; set; }
        public string? NumeroDocumento { get; set; }
        public string TipoOperacion { get; set; } = null!;
        public string? ProductoDescripcion { get; set; }
        public string CodigoUnidadBase { get; set; } = null!;
        public string CodigoMetodoEvaluacion { get; set; } = null!;
        public string? CantidadIngresoUbase { get; set; }
        public string? ValorUnitarioIngreso { get; set; }
        public string? ValorTotalIngreso { get; set; }
        public string? CantidadRetiroUbase { get; set; }
        public string? ValorUnitarioRetiro { get; set; }
        public string? ValorTotalRetiro { get; set; }
        public string? Columna20 { get; set; }
        public string? Columna21 { get; set; }
        public string? Columna22 { get; set; }
        public int? Estado { get; set; }
        public string CampoLibre { get; set; } = null!;
        public int Idperiodo { get; set; }
        public int Idproducto { get; set; }
        public bool AfectaCostoPromedio { get; set; }
        public string CodigoUnidadReferencia { get; set; } = null!;
        public int FactorUnidadReferencia { get; set; }
    }
}
