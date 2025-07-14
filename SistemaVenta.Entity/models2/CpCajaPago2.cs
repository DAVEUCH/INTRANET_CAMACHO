using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpCajaPago2
    {
        public int Pkid { get; set; }
        public int IdcpCaja { get; set; }

        public virtual CpCaja IdcpCajaNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
    }
}
