using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteLibroDiarioExportacion
    {
        public string Periodo { get; set; } = null!;
        public string CodigoOperacion { get; set; } = null!;
        public string CodigoPlanCuentas { get; set; } = null!;
        public string? CodigoCuentaContable { get; set; }
        public string? FechaOperacion { get; set; }
        public string Glosa { get; set; } = null!;
        public string? Debe { get; set; }
        public string? Haber { get; set; }
        public int? EstadoOperacion { get; set; }
        public string CampoLibre { get; set; } = null!;
        public int Idperiodo { get; set; }
        public int EsDebe { get; set; }
    }
}
