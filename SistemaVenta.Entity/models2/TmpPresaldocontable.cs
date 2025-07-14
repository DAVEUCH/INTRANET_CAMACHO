using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TmpPresaldocontable
    {
        public int IdcuentaContable { get; set; }
        public int? IdplanCuentas { get; set; }
        public string? Cuenta { get; set; }
        public int IddocCobrarPagar { get; set; }
        public decimal? SaldoSoles { get; set; }
        public decimal? SaldoDolares { get; set; }
        public decimal? SaldoSolesContable { get; set; }
        public decimal? SaldoDolaresContable { get; set; }
    }
}
