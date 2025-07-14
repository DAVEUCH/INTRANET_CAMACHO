using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpContabilizable
    {
        public int Pkid { get; set; }
        public string Idtipo { get; set; } = null!;
        public int IdcpContabilizableBatch { get; set; }

        public virtual CpContabilizableBatch IdcpContabilizableBatchNavigation { get; set; } = null!;
        public virtual Clasificador IdtipoNavigation { get; set; } = null!;
    }
}
