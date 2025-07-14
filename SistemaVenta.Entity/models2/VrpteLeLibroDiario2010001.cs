using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteLeLibroDiario2010001
    {
        public int? Periodo { get; set; }
        public string CodigoOperacion { get; set; } = null!;
        public string? NumeroCorrelativo { get; set; }
        public string CodigoPlanCuentas { get; set; } = null!;
        public string? CodigoCuentaContable { get; set; }
        public string? FechaOperacion { get; set; }
        public DateTime FechaOperacion2 { get; set; }
        public string Glosa { get; set; } = null!;
        public string? Debe { get; set; }
        public string? Haber { get; set; }
        public string CorrelativoRegistroVentas { get; set; } = null!;
        public string CorrelativoRegistroCompras { get; set; } = null!;
        public string CorrelativoRegistroConsignaciones { get; set; } = null!;
        public int? EstadoOperacion { get; set; }
        public string CampoLibre { get; set; } = null!;
        public int Idperiodo { get; set; }
        public int EsDebe { get; set; }
    }
}
