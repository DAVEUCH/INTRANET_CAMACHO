using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ParametroCr
    {
        public string Pkid { get; set; } = null!;
        public string Idreporte { get; set; } = null!;
        public string Idparametro { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string RutaCe { get; set; } = null!;

        public virtual Parametro IdparametroNavigation { get; set; } = null!;
        public virtual Reporte IdreporteNavigation { get; set; } = null!;
    }
}
