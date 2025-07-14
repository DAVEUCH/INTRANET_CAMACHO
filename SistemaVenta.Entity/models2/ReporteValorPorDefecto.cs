using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ReporteValorPorDefecto
    {
        public ReporteValorPorDefecto()
        {
            ParametroValorPorDefectos = new HashSet<ParametroValorPorDefecto>();
        }

        public int Pkid { get; set; }
        public string Idreporte { get; set; } = null!;
        public int Idusuario { get; set; }

        public virtual Reporte IdreporteNavigation { get; set; } = null!;
        public virtual Usuario IdusuarioNavigation { get; set; } = null!;
        public virtual ICollection<ParametroValorPorDefecto> ParametroValorPorDefectos { get; set; }
    }
}
