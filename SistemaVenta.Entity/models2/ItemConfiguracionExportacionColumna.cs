using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemConfiguracionExportacionColumna
    {
        public string Pkid { get; set; } = null!;
        public string? Nombre { get; set; }
        public int? Posicion { get; set; }
        public bool? EsId { get; set; }
        public string? IdconfiguracionExportacion { get; set; }
        public bool? Exportar { get; set; }

        public virtual ConfiguracionExportacion? IdconfiguracionExportacionNavigation { get; set; }
    }
}
