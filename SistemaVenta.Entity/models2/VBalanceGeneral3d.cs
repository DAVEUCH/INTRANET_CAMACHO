using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VBalanceGeneral3d
    {
        public string Cuenta { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public decimal? Saldo { get; set; }
        public decimal? SaldoAcumulado { get; set; }
        public int Idperiodo { get; set; }
    }
}
