using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalSaldoPeriodoCuentaContable2
    {
        public int Idperiodo { get; set; }
        public int IdcuentaContable { get; set; }
        public decimal? SaldoCargo { get; set; }
        public decimal? SaldoAbono { get; set; }
        public int SaldoAcumuladoAbono { get; set; }
        public int SaldoAcumuladoCargo { get; set; }
    }
}
