using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrptSaldoMayor
    {
        public string? Cuenta { get; set; }
        public decimal? Saldo { get; set; }
        public int Idperiodo { get; set; }
        public int IdcuentaContable { get; set; }
        public int Idejercicio { get; set; }
        public string Periodo { get; set; } = null!;
    }
}
