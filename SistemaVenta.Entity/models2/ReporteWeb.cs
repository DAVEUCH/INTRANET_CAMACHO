using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ReporteWeb
    {
        public string Pkid { get; set; } = null!;
        public int? Ancho { get; set; }
        public int? Largo { get; set; }
        public bool? TamañoFijo { get; set; }
        public string? ModoMostrar { get; set; }
        public bool? EnviarUsuario { get; set; }
        public bool? MostrarUrl { get; set; }
        public string? Url { get; set; }

        public virtual Reporte Pk { get; set; } = null!;
    }
}
