using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CptoOperacionCuentaContable
    {
        public int Pkid { get; set; }
        public int IdcptoOperacion { get; set; }
        public int IdcuentaContable { get; set; }
        public bool Obligatorio { get; set; }

        public virtual CptoOperacion IdcptoOperacionNavigation { get; set; } = null!;
        public virtual CuentaContable IdcuentaContableNavigation { get; set; } = null!;
    }
}
