using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalDocCobrarPagarSaldo2
    {
        public int Pkid { get; set; }
        public decimal Saldo { get; set; }
        public decimal? SaldoContable { get; set; }
    }
}
