using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EProductoDescuento
    {
        public int ProductosId { get; set; }
        public int Iddescuento { get; set; }
        public int ProductosIdproducto { get; set; }
    }
}
