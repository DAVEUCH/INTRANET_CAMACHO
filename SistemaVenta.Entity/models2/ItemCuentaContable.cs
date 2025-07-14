using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCuentaContable
    {
        public int Pkid { get; set; }
        public int IdcuentaContable { get; set; }
        public int IdtipoAuxiliar { get; set; }
        public int Idauxiliar { get; set; }
        public int IdcentroDeCosto { get; set; }

        public virtual CentroDeCosto IdcentroDeCostoNavigation { get; set; } = null!;
        public virtual CuentaContable IdcuentaContableNavigation { get; set; } = null!;
        public virtual ItemCp Pk { get; set; } = null!;
    }
}
