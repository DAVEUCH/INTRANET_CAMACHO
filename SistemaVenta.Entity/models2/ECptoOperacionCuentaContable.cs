using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECptoOperacionCuentaContable
    {
        public int CuentasContablesId { get; set; }
        public int IdcptoOperacion { get; set; }
        public int CuentasContablesIdcuentaContable { get; set; }
        public bool CuentasContablesObligatorio { get; set; }
    }
}
