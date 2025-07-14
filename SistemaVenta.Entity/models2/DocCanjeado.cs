using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DocCanjeado
    {
        public int Pkid { get; set; }
        public int IddocCobrarPagar { get; set; }
        public decimal MontoAcanjear { get; set; }
        public int IdcanjeLetras { get; set; }
    }
}
