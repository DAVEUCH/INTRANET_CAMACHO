using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class NivelPlanCuenta
    {
        public int IdplanCuentas { get; set; }
        public int NumeroDigitos { get; set; }
        public string Separador { get; set; } = null!;

        public virtual PlanCuenta IdplanCuentasNavigation { get; set; } = null!;
    }
}
