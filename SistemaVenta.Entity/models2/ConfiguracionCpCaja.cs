using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ConfiguracionCpCaja
    {
        public int Pkid { get; set; }
        public int SaldoContable { get; set; }
        public int SaldoDisponible { get; set; }
        public string TipoMovimiento { get; set; } = null!;

        public virtual CptoOperacion Pk { get; set; } = null!;
    }
}
