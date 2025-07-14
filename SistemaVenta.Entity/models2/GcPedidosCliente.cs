using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GcPedidosCliente
    {
        public int? Idpedido { get; set; }
        public int? IdModalEntrePed { get; set; }
        public int? IdmodalCredito { get; set; }
        public int? DiasCredito { get; set; }
        public int? NroLetras { get; set; }
        public int? IdprovisionLetras { get; set; }
    }
}
