using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvCuentaContableTransferencia
    {
        public string PlanCuenta { get; set; } = null!;
        public string? Cuenta { get; set; }
        public string? DescripcionCuentaContable { get; set; }
        public string? CtaTransferencia { get; set; }
        public string? DescripcionCtaTransferencia { get; set; }
        public int Porcentaje { get; set; }
    }
}
