using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VEgpporFuncion
    {
        public int Idnivel { get; set; }
        public string Nivel1 { get; set; } = null!;
        public string Nivel2 { get; set; } = null!;
        public decimal? Saldo { get; set; }
        public decimal? SaldoPeriodo { get; set; }
        public string Cuenta { get; set; } = null!;
        public int Idperiodo { get; set; }
    }
}
