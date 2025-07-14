using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VpruebaCpVentum
    {
        public DateTime FechaEmision { get; set; }
        public string NumCp { get; set; } = null!;
        public string? PersonaNombre { get; set; }
        public decimal Total { get; set; }
        public string Codigo { get; set; } = null!;
    }
}
