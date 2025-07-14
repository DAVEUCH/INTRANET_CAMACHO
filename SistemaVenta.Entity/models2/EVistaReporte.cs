using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EVistaReporte
    {
        public string VistasReporteId { get; set; } = null!;
        public string Idreporte { get; set; } = null!;
        public string VistasReporteNombre { get; set; } = null!;
        public string VistasReporteTexto { get; set; } = null!;
        public int VistasReporteTipoVista { get; set; }
        public int VistasReportePosicion { get; set; }
    }
}
