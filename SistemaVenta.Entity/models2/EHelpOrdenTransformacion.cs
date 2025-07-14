using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EHelpOrdenTransformacion
    {
        public int IdordenTransformacion { get; set; }
        public int BalanceEntrada { get; set; }
        public int IdcpInventario { get; set; }
    }
}
