using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemProductoAlmacen
    {
        public int IdcpInventario { get; set; }
        public int IditemProducto { get; set; }
        public int Idalmacen { get; set; }
    }
}
