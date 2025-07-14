using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvConsolidadoCabecerayDetalleDoc
    {
        public int Idconsolidado { get; set; }
        public string ConsolidadoNro { get; set; } = null!;
        public string? ConsolidadoFechaEmision { get; set; }
        public string? ConsolidadoHoraEmision { get; set; }
        public int Idfactura { get; set; }
        public string FacturaNro { get; set; } = null!;
    }
}
