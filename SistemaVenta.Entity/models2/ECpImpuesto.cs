using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECpImpuesto
    {
        public int Pkid { get; set; }
        public int Idimpuesto { get; set; }
        public bool PreciosIncImpto { get; set; }
        public decimal ValorVenta { get; set; }
        public decimal TotalInafecto { get; set; }
    }
}
