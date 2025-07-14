using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteComprobantesRegistroVenta
    {
        public int Pkid { get; set; }
        public int Idimpuesto { get; set; }
        public string DocIdentidad { get; set; } = null!;
        public decimal ValorVenta { get; set; }
        public bool PreciosIncImpto { get; set; }
        public decimal ValorInafecto { get; set; }
    }
}
