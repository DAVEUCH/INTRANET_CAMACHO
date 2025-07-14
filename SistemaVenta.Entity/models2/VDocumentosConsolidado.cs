using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VDocumentosConsolidado
    {
        public int IdconsolidadoCarga { get; set; }
        public int Idcp { get; set; }
        public string Tipo { get; set; } = null!;
        public int Orden { get; set; }
        public string Grupo { get; set; } = null!;
    }
}
