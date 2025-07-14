using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VGlosasPaso
    {
        public int Idconcepto { get; set; }
        public string Glosa { get; set; } = null!;
        public string? SubDiario { get; set; }
        public bool ResumirEnLibroDiario { get; set; }
        public int Idasiento { get; set; }
        public string Observacion { get; set; } = null!;
        public int Idproceso { get; set; }
        public bool Contabilizable { get; set; }
    }
}
