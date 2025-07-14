using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VPasosProceso
    {
        public int Idproceso { get; set; }
        public int Orden { get; set; }
        public int IdpasosProceso { get; set; }
        public string Paso { get; set; } = null!;
        public string? ObsPaso { get; set; }
        public int Idconcepto { get; set; }
        public string ConceptoCodigo { get; set; } = null!;
        public string Concepto { get; set; } = null!;
        public string TipoCpAsociado { get; set; } = null!;
        public bool Contabilizable { get; set; }
        public string CreadoPartirDe { get; set; } = null!;
        public bool Activo { get; set; }
        public string? IdtipoTarea { get; set; }
        public bool? TieneCpInventario { get; set; }
        public bool? TieneCpCaja { get; set; }
        public bool? TieneCpCobrarPagar { get; set; }
        public bool? TieneCpOrigen { get; set; }
    }
}
