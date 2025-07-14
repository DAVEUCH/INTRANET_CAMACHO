using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ParametroValorPorDefecto
    {
        public int Pkid { get; set; }
        public int IdreporteValorPorDefecto { get; set; }
        public string Idparametro { get; set; } = null!;
        public string Valor { get; set; } = null!;
        public int Posicion { get; set; }
        public bool EsListado { get; set; }
        public string RutaPropiedad { get; set; } = null!;

        public virtual ReporteValorPorDefecto IdreporteValorPorDefectoNavigation { get; set; } = null!;
    }
}
