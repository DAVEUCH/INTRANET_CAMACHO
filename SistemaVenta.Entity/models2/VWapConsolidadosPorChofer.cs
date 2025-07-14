using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VWapConsolidadosPorChofer
    {
        public string Pkid { get; set; } = null!;
        public int Idusuario { get; set; }
        public string Filtro { get; set; } = null!;
        public int AnchoInicial { get; set; }
    }
}
