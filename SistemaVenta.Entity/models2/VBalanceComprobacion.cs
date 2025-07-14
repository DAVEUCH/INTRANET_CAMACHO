using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VBalanceComprobacion
    {
        public int Pkidcc { get; set; }
        public string? Cuenta { get; set; }
        public string? Descripcion { get; set; }
        public string? TipoCuenta { get; set; }
        public decimal? Cargo { get; set; }
        public decimal? Abono { get; set; }
        public decimal? Saldo { get; set; }
    }
}
