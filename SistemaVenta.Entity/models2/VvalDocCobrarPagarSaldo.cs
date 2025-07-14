using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalDocCobrarPagarSaldo
    {
        public int Pkid { get; set; }
        public string NumCp { get; set; } = null!;
        public decimal Total { get; set; }
        public decimal? Amortizacion { get; set; }
        public decimal? SaldoCc { get; set; }
        public decimal Saldo { get; set; }
    }
}
