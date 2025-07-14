using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GcCcyCtaContyRubroyCosto
    {
        public int PkidCc { get; set; }
        public string? Cc { get; set; }
        public string CuentaContable { get; set; } = null!;
        public string? Costo { get; set; }
        public string? Rubro { get; set; }
        public int IdplanCuentas { get; set; }
        public int Idxx { get; set; }
    }
}
