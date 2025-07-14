using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VObtenerCuentasContableDesdeCpCaja
    {
        public int Pkid { get; set; }
        public string? Cuenta { get; set; }
        public string? TipoCuenta { get; set; }
        public int? Idpadre { get; set; }
        public int? CuentaContableNivel { get; set; }
        public int PlanCuentasNivel { get; set; }
    }
}
