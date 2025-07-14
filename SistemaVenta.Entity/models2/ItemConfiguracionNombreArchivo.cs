using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemConfiguracionNombreArchivo
    {
        public string Pkid { get; set; } = null!;
        public string? RutaValor { get; set; }
        public int? Posicion { get; set; }
        public string? Idparametro { get; set; }
        public string? IdconfiguracionExportacion { get; set; }

        public virtual ConfiguracionExportacion? IdconfiguracionExportacionNavigation { get; set; }
    }
}
