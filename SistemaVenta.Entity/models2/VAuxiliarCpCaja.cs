using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAuxiliarCpCaja
    {
        public int Idcp { get; set; }
        public int Idcaja { get; set; }
        public decimal? SaldoDisponibleSoles { get; set; }
        public decimal? SaldoContableSoles { get; set; }
        public decimal? SaldoDisponibleDolares { get; set; }
        public decimal? SaldoContableDolares { get; set; }
    }
}
