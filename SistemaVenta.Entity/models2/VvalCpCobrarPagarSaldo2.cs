using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalCpCobrarPagarSaldo2
    {
        public int Pkid { get; set; }
        public decimal Total { get; set; }
        public decimal Saldo { get; set; }
        public decimal? TotalContable { get; set; }
        public decimal? SaldoContable { get; set; }
    }
}
