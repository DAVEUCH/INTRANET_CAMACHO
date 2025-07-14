using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemConfiguracionExportacionColumna
    {
        public int ItemsConfiguracionColumnasId { get; set; }
        public string? ItemsConfiguracionColumnasNombre { get; set; }
        public int? ItemsConfiguracionColumnasPosicion { get; set; }
        public bool? ItemsConfiguracionColumnasEsId { get; set; }
        public int? IdconfiguracionExportacion { get; set; }
        public bool? ItemsConfiguracionColumnasExportar { get; set; }
    }
}
