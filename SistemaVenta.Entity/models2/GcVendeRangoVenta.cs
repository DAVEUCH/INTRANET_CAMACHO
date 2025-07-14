using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GcVendeRangoVenta
    {
        public string? ChCodCatVende { get; set; }
        public decimal? DePorceVenta { get; set; }
        public decimal? DeCuotaVenta { get; set; }
        public decimal? DeCuotaVentaMax { get; set; }
    }
}
