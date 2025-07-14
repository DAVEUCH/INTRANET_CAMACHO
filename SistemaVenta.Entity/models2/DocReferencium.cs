using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DocReferencium
    {
        public int Pkid { get; set; }
        public int Iddocumento { get; set; }
        public int IdtipoComprobantePago { get; set; }
        public string Serie { get; set; } = null!;
        public string Numero { get; set; } = null!;
        public DateTime Fecha { get; set; }
    }
}
