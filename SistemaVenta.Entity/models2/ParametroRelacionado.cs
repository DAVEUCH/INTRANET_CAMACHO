using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ParametroRelacionado
    {
        public string Pkid { get; set; } = null!;
        public string Idparametro { get; set; } = null!;
        public string IdparametroRelacionado { get; set; } = null!;
        public string RutaCeparametro { get; set; } = null!;
        public string RutaCeparametroRelacionado { get; set; } = null!;
        public string OperadorRelacion { get; set; } = null!;

        public virtual Parametro IdparametroNavigation { get; set; } = null!;
        public virtual Parametro IdparametroRelacionadoNavigation { get; set; } = null!;
    }
}
