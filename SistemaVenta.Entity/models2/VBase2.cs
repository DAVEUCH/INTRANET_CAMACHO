using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VBase2
    {
        public int Flag { get; set; }
        public string? Cuenta { get; set; }
        public string? Descripcion { get; set; }
        public string? TipoCuenta { get; set; }
        public decimal? Cargo { get; set; }
        public decimal? Abono { get; set; }
        public decimal? SaldoAcumulado { get; set; }
        public int Idperiodo { get; set; }
        public int IdcuentaContable { get; set; }
        public decimal? CargoPeriodo { get; set; }
        public decimal? AbonoPeriodo { get; set; }
        public decimal? Saldo { get; set; }
        public int Idejercicio { get; set; }
        public string Periodo { get; set; } = null!;
    }
}
