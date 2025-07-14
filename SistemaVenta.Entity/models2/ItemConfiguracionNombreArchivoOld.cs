using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemConfiguracionNombreArchivoOld
    {
        public int Pkid { get; set; }
        public string? RutaValor { get; set; }
        public int? Posicion { get; set; }
        public string? Idparametro { get; set; }
        public int? IdconfiguracionExportacion { get; set; }

        public virtual ConfiguracionExportacionOld? IdconfiguracionExportacionNavigation { get; set; }
    }
}
