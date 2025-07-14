using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteSaldosPorCuentaySegmento
    {
        public string? CuentaContableNumero { get; set; }
        public string? CuentaContableDescripcion { get; set; }
        public string SegmentoNombre { get; set; } = null!;
        public int PeriodoId { get; set; }
        public decimal SaldoAbono { get; set; }
        public decimal SaldoCargo { get; set; }
    }
}
