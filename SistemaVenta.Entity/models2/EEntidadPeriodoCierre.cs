using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EEntidadPeriodoCierre
    {
        public int ItemsId { get; set; }
        public int IdconfiguracionPeriodoCierre { get; set; }
        public string ItemsIdentidadCierre { get; set; } = null!;
        public int ItemsIdentidad { get; set; }
    }
}
