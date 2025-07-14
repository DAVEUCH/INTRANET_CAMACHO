using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DistribucionCostosCuentasContable
    {
        public int Pkid { get; set; }
        public int IdcuentaContable { get; set; }
        public int IddistribucionCosto { get; set; }

        public virtual CuentaContable IdcuentaContableNavigation { get; set; } = null!;
        public virtual DistribucionCosto IddistribucionCostoNavigation { get; set; } = null!;
    }
}
