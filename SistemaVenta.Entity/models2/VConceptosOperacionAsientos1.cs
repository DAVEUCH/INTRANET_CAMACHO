using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VConceptosOperacionAsientos1
    {
        public int IdcptoOperacion { get; set; }
        public string Glosa { get; set; } = null!;
        public string? SubDiario { get; set; }
        public bool ResumirEnLibroDiario { get; set; }
        public int Pkid { get; set; }
        public string Observacion { get; set; } = null!;
    }
}
