using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ParametroSql
    {
        public string Pkid { get; set; } = null!;
        public string Idparametro { get; set; } = null!;
        public string IdvistaReporte { get; set; } = null!;
        public string Campo { get; set; } = null!;
        public string Condicion { get; set; } = null!;
        public bool? Concatenar { get; set; }
        public bool Reemplazar { get; set; }
        public string TextoAreemplazar { get; set; } = null!;
        public string RutaCe { get; set; } = null!;
        public int Posicion { get; set; }

        public virtual Parametro IdparametroNavigation { get; set; } = null!;
        public virtual VistaReporte IdvistaReporteNavigation { get; set; } = null!;
    }
}
