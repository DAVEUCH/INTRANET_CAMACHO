using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpContabilizable
    {
        public int CpsId { get; set; }
        public string CpsIdtipo { get; set; } = null!;
        public int IdcpContabilizableBatch { get; set; }
    }
}
