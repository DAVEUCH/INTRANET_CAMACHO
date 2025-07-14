using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductoListaInventario
    {
        public ProductoListaInventario()
        {
            UnidadProductoListaInventarios = new HashSet<UnidadProductoListaInventario>();
        }

        public int Pkid { get; set; }
        public int IdlistaInventario { get; set; }
        public int Idproducto { get; set; }

        public virtual ListaInventario IdlistaInventarioNavigation { get; set; } = null!;
        public virtual ProductoServicio IdproductoNavigation { get; set; } = null!;
        public virtual ICollection<UnidadProductoListaInventario> UnidadProductoListaInventarios { get; set; }
    }
}
