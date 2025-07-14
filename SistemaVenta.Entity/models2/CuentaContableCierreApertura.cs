using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CuentaContableCierreApertura
    {
        public int Pkid { get; set; }
        public int IdconfiguracionCierreApertura { get; set; }
        public int IdcuentaContable { get; set; }

        public virtual ConfiguracionCierreApertura IdconfiguracionCierreAperturaNavigation { get; set; } = null!;
        public virtual CuentaContable IdcuentaContableNavigation { get; set; } = null!;
    }
}
