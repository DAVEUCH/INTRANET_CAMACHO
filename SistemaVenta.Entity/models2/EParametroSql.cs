using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EParametroSql
    {
        public string ParametrosId { get; set; } = null!;
        public string ParametrosIdparametro { get; set; } = null!;
        public string IdvistaReporte { get; set; } = null!;
        public string ParametrosCampo { get; set; } = null!;
        public string ParametrosCondicion { get; set; } = null!;
        public bool ParametrosConcatenar { get; set; }
        public bool ParametrosReemplazar { get; set; }
        public string ParametrosTextoAreemplazar { get; set; } = null!;
        public string ParametrosRutaCe { get; set; } = null!;
        public int Posicion { get; set; }
    }
}
