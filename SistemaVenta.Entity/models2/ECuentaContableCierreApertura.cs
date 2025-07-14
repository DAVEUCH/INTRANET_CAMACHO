using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECuentaContableCierreApertura
    {
        public int CuentasContablesId { get; set; }
        public int IdconfiguracionCierreApertura { get; set; }
        public int CuentasContablesIdcuentaContable { get; set; }
    }
}
