using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionCpCobrarPagar
    {
        public int Pkid { get; set; }
        public string TipoCpCobrarPagar { get; set; } = null!;
        public int MovSaldo { get; set; }

        public virtual CptoOperacion Pk { get; set; } = null!;
    }
}
