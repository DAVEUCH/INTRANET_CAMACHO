using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDocCanjeado
    {
        public int CanjeLetrasDocCanjeadosId { get; set; }
        public int CanjeLetrasDocCanjeadosIddocCobrarPagar { get; set; }
        public decimal CanjeLetrasDocCanjeadosMontoAcanjear { get; set; }
        public int CanjeLetrasIdcanjeLetras { get; set; }
        public int CanjeLetras3DocCanjeadosId { get; set; }
        public int CanjeLetras3DocCanjeadosIddocCobrarPagar { get; set; }
        public decimal CanjeLetras3DocCanjeadosMontoAcanjear { get; set; }
        public int CanjeLetras3IdcanjeLetras { get; set; }
    }
}
