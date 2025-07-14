using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CuentaContableCentroCosto
    {
        public int Pkid { get; set; }
        public int IdcuentaContable { get; set; }
        public int IdcentroCosto { get; set; }
        public decimal Porcentaje { get; set; }

        public virtual CentroDeCosto IdcentroCostoNavigation { get; set; } = null!;
        public virtual CuentaContable IdcuentaContableNavigation { get; set; } = null!;
    }
}
