using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VerificacionCuentasporcobrarpagar
    {
        public string? Cuenta { get; set; }
        public DateTime Fecha { get; set; }
        public string NumCp { get; set; } = null!;
        public decimal? SaldoSoles { get; set; }
        public decimal? SaldoDolares { get; set; }
    }
}
