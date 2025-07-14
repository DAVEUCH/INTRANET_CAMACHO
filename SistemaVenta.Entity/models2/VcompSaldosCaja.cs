using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VcompSaldosCaja
    {
        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal? SaldoSoles { get; set; }
        public decimal? SaldoDisponibleSoles { get; set; }
        public decimal? SaldoDolares { get; set; }
        public decimal? SaldoDisponibleDolares { get; set; }
    }
}
