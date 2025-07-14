using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EConfiguracionCpCobrarPagar
    {
        public int Id { get; set; }
        public string TipoCpCobrarPagar { get; set; } = null!;
        public int MovSaldo { get; set; }
    }
}
