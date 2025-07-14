using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteLibroDiarioSimplificado2010
    {
        public int Idperiodo { get; set; }
        public string NumOperacion { get; set; } = null!;
        public DateTime Fecha { get; set; }
        public string Glosa { get; set; } = null!;
        public string? Cuenta { get; set; }
        public string Periodo { get; set; } = null!;
        public string? TipoCuenta { get; set; }
        public decimal? Saldo { get; set; }
    }
}
