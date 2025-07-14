using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class NotaDebito
    {
        public int Pkid { get; set; }
        public string DocIdentidad { get; set; } = null!;
        public int IdcpInventario { get; set; }

        public virtual Cp Pk { get; set; } = null!;
    }
}
