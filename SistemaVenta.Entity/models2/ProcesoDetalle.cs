using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProcesoDetalle
    {
        public int Iddetalle { get; set; }
        public int? Idproceso { get; set; }
        public int? IdcptoOperacion { get; set; }
    }
}
