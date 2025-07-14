using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ENivelPlanCuenta
    {
        public int IdplanCuentas { get; set; }
        public int NivelesNumeroDigitos { get; set; }
        public string NivelesSeparador { get; set; } = null!;
    }
}
