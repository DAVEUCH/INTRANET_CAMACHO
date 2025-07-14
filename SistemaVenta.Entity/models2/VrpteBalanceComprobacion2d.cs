using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteBalanceComprobacion2d
    {
        public string? Cuenta { get; set; }
        public string? Descripcion { get; set; }
        public string? TipoCuenta { get; set; }
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
        public string PeriodoMes { get; set; } = null!;
        public string EjercicioAño { get; set; } = null!;
    }
}
