using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VWapClientesConsolidado
    {
        public int IdconsolidadoCarga { get; set; }
        public int Id { get; set; }
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public int Pkidzona { get; set; }
    }
}
