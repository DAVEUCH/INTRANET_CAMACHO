using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteSaldosCajaCtaBancarium
    {
        public int SaldoCajaIdcaja { get; set; }
        public string SaldoCajaCodigo { get; set; } = null!;
        public string SaldoCajaNombre { get; set; } = null!;
        public string SaldoCajaTipoCaja { get; set; } = null!;
    }
}
