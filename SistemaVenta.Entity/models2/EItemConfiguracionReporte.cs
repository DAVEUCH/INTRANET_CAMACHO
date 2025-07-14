using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemConfiguracionReporte
    {
        public int ItemsConfiguracionReporteId { get; set; }
        public bool ItemsConfiguracionReporteVisible { get; set; }
        public string ItemsConfiguracionReporteIdreporte { get; set; } = null!;
        public int IdconfiguracionReporte { get; set; }
    }
}
