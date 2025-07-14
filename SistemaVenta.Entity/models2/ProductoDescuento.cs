using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductoDescuento
    {
        public int Pkid { get; set; }
        public int Iddescuento { get; set; }
        public int Idproducto { get; set; }

        public virtual ProductoServicio IdproductoNavigation { get; set; } = null!;
    }
}
