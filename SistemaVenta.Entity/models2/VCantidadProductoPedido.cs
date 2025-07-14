using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VCantidadProductoPedido
    {
        public int Idproducto { get; set; }
        public int? CantidadBase { get; set; }
        public int IdcpOrigen { get; set; }
    }
}
