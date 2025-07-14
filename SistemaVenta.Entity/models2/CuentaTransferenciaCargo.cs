using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CuentaTransferenciaCargo
    {
        public int Pkid { get; set; }
        public int IdcuentaContable { get; set; }
        public int IdcuentaContableCargo { get; set; }
        public int Porcentaje { get; set; }

        public virtual CuentaContable IdcuentaContableNavigation { get; set; } = null!;
    }
}
