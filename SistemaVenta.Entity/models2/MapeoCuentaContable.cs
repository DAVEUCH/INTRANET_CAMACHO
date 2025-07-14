using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class MapeoCuentaContable
    {
        public MapeoCuentaContable()
        {
            InverseIdmapeoCuentaContablePadreNavigation = new HashSet<MapeoCuentaContable>();
        }

        public int Pkid { get; set; }
        public int IdmapeoCuentaContablePadre { get; set; }
        public int IdcuentaContable { get; set; }
        public string Idtipo { get; set; } = null!;
        public string Filtro { get; set; } = null!;
        public int SubCuentas { get; set; }
        public string Clave { get; set; } = null!;
        public int Nivel { get; set; }

        public virtual CuentaContable IdcuentaContableNavigation { get; set; } = null!;
        public virtual MapeoCuentaContable IdmapeoCuentaContablePadreNavigation { get; set; } = null!;
        public virtual Tipo IdtipoNavigation { get; set; } = null!;
        public virtual ICollection<MapeoCuentaContable> InverseIdmapeoCuentaContablePadreNavigation { get; set; }
    }
}
