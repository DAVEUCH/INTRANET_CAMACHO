using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CuentaTransferenciaAbono
    {
        public int Pkid { get; set; }
        public int IdcuentaContable { get; set; }
        public int IdcuentaContableAbono { get; set; }
        public int Porcentaje { get; set; }

        public virtual CuentaContable IdcuentaContableAbonoNavigation { get; set; } = null!;
        public virtual CuentaContable IdcuentaContableNavigation { get; set; } = null!;
    }
}
