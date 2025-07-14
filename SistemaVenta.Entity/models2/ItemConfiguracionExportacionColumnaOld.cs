using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemConfiguracionExportacionColumnaOld
    {
        public int Pkid { get; set; }
        public string? Nombre { get; set; }
        public int? Posicion { get; set; }
        public bool? EsId { get; set; }
        public int? IdconfiguracionExportacion { get; set; }
        public bool? Exportar { get; set; }

        public virtual ConfiguracionExportacionOld? IdconfiguracionExportacionNavigation { get; set; }
    }
}
