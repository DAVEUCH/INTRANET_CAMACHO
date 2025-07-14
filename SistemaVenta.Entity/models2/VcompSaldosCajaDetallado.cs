using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VcompSaldosCajaDetallado
    {
        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public decimal SaldoSoles { get; set; }
        public decimal SaldoDisponibleSoles { get; set; }
        public decimal SaldoDolares { get; set; }
        public decimal SaldoDisponibleDolares { get; set; }
        public decimal? SaldoSolesComprobacion { get; set; }
        public decimal? SaldoDisponibleSolesComprobacion { get; set; }
        public decimal? SaldoDolaresComprobacion { get; set; }
        public decimal? SaldoDisponibleDolaresComprobacion { get; set; }
        public decimal? SaldoSolesDiferencia { get; set; }
        public decimal? SaldoDisponibleSolesDiferencia { get; set; }
        public decimal? SaldoDolaresDiferencia { get; set; }
        public decimal? SaldoDisponibleDolaresDiferencia { get; set; }
    }
}
