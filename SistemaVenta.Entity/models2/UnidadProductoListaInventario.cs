using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UnidadProductoListaInventario
    {
        public int Pkid { get; set; }
        public int IdproductoListaInventario { get; set; }
        public int Idunidad { get; set; }
        public int Conteo1 { get; set; }
        public int Conteo2 { get; set; }
        public int Conteo3 { get; set; }
        public bool Predeterminado { get; set; }

        public virtual ProductoListaInventario IdproductoListaInventarioNavigation { get; set; } = null!;
        public virtual Unidad IdunidadNavigation { get; set; } = null!;
    }
}
