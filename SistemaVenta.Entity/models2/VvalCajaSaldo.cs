using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalCajaSaldo
    {
        public int Idcaja { get; set; }
        public decimal? SaldoSolesCc { get; set; }
        public decimal SaldoSoles { get; set; }
        public decimal? SaldoDolaresCc { get; set; }
        public decimal SaldoDolares { get; set; }
        public decimal? SaldoDisponibleSolesCc { get; set; }
        public decimal SaldoDisponibleSoles { get; set; }
        public decimal? SaldoDisponibleDolaresCc { get; set; }
        public decimal SaldoDisponibleDolares { get; set; }
    }
}
