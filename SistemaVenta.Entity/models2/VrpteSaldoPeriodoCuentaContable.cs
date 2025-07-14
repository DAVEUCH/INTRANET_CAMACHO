using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteSaldoPeriodoCuentaContable
    {
        public string? SaldoCuentaNumero { get; set; }
        public string? SaldoCuentaDescripcion { get; set; }
        public decimal SaldoCargoMonedaBase { get; set; }
        public decimal SaldoAbnoMonedaBase { get; set; }
        public decimal? SaldoMonedaBase { get; set; }
        public int SaldoPeriodoId { get; set; }
        public string SaldoPeriodoDescripcion { get; set; } = null!;
        public int SaldoEjercicioId { get; set; }
        public string SaldoEjercicioDescripcion { get; set; } = null!;
    }
}
