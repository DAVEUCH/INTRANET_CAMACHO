using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EntidadPeriodoCierre
    {
        public int Pkid { get; set; }
        public int IdconfiguracionPeriodoCierre { get; set; }
        public string IdentidadCierre { get; set; } = null!;
        public int Identidad { get; set; }
    }
}
