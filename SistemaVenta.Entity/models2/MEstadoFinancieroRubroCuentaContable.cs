using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class MEstadoFinancieroRubroCuentaContable
    {
        public int Pkid { get; set; }
        public string CuentaContable { get; set; } = null!;
        public int TipoSaldo { get; set; }
        public int IdestadoFinancieroRubro { get; set; }
        public decimal Porcentaje2 { get; set; }
        public decimal? Porcentaje { get; set; }
    }
}
