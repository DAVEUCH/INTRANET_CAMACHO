using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EParametroRelacionado
    {
        public string ParametrosRelacionadosId { get; set; } = null!;
        public string Idparametro { get; set; } = null!;
        public string ParametrosRelacionadosIdparametroRelacionado { get; set; } = null!;
        public string ParametrosRelacionadosRutaCeparametro { get; set; } = null!;
        public string ParametrosRelacionadosRutaCeparametroRelacionado { get; set; } = null!;
        public string ParametrosRelacionadosOperadorRelacion { get; set; } = null!;
    }
}
