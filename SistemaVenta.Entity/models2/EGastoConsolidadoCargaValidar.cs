using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EGastoConsolidadoCargaValidar
    {
        public int IdconsolidadoCarga { get; set; }
        public int Idgasto { get; set; }
        public string NumCp { get; set; } = null!;
    }
}
