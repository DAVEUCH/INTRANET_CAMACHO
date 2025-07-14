using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VItemConsolidadoCarga
    {
        public int Id { get; set; }
        public int IdconsolidadoCarga { get; set; }
        public string TipoCp { get; set; } = null!;
        public string IdcpRelacionado { get; set; } = null!;
    }
}
