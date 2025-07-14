using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemConfiguracionReporte
    {
        public int Pkid { get; set; }
        public bool Visible { get; set; }
        public string Idreporte { get; set; } = null!;
        public int IdconfiguracionReporte { get; set; }

        public virtual ConfiguracionReporte IdconfiguracionReporteNavigation { get; set; } = null!;
        public virtual Reporte IdreporteNavigation { get; set; } = null!;
    }
}
