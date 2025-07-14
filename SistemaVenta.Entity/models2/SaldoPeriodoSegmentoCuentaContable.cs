using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class SaldoPeriodoSegmentoCuentaContable
    {
        public int IdcuentaContable { get; set; }
        public int Idperiodo { get; set; }
        public int Idauxiliar { get; set; }
        public decimal SaldoAbono { get; set; }
        public decimal SaldoCargo { get; set; }
        public decimal SaldoAcumuladoAbono { get; set; }
        public decimal SaldoAcumuladoCargo { get; set; }

        public virtual CuentaContable IdcuentaContableNavigation { get; set; } = null!;
        public virtual Periodo IdperiodoNavigation { get; set; } = null!;
    }
}
