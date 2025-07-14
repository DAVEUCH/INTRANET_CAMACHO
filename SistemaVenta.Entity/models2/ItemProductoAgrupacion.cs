using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemProductoAgrupacion
    {
        public int Pkid { get; set; }
        public int IditemProducto { get; set; }
        public int Idproducto { get; set; }
        public int Cantidad { get; set; }

        public virtual ItemProducto IditemProductoNavigation { get; set; } = null!;
        public virtual Producto IdproductoNavigation { get; set; } = null!;
    }
}
