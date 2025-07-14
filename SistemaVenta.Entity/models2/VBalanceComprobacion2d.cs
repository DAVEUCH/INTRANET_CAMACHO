using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VBalanceComprobacion2d
    {
        public string Cuenta { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string TipoCuenta { get; set; } = null!;
        public decimal? Cargo { get; set; }
        public decimal? Abono { get; set; }
        public decimal? Saldo { get; set; }
        public int Idperiodo { get; set; }
        public int Pkid { get; set; }
        public decimal? CargoPeriodo { get; set; }
        public decimal? AbonoPeriodo { get; set; }
        public decimal? SaldoPeriodo { get; set; }
        public int Idejercicio { get; set; }
        public string Periodo { get; set; } = null!;
    }
}
