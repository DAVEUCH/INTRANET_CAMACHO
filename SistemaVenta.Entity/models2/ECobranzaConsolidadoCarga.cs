using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECobranzaConsolidadoCarga
    {
        public int Id { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public int Idcobranza { get; set; }
    }
}
