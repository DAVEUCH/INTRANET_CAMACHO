using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class OrdenamientoSql
    {
        public string Pkid { get; set; } = null!;
        public string IdvistaReporte { get; set; } = null!;
        public string Idordenamiento { get; set; } = null!;
        public string SqlorderBy { get; set; } = null!;

        public virtual Ordenamiento IdordenamientoNavigation { get; set; } = null!;
        public virtual VistaReporte IdvistaReporteNavigation { get; set; } = null!;
    }
}
