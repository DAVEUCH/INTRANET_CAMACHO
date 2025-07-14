using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemProductoAlmacen
    {
        public int IdcpInventario { get; set; }
        public int IditemProducto { get; set; }
        public int Idalmacen { get; set; }

        public virtual Almacen IdalmacenNavigation { get; set; } = null!;
        public virtual CpInventario IdcpInventarioNavigation { get; set; } = null!;
    }
}
