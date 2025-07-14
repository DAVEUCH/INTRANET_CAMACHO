using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EUnidadProductoListaInventario
    {
        public int UnidadesProductoListaId { get; set; }
        public int IdproductoListaInventario { get; set; }
        public int UnidadesProductoListaIdunidad { get; set; }
        public int UnidadesProductoListaConteo1 { get; set; }
        public int UnidadesProductoListaConteo2 { get; set; }
        public int UnidadesProductoListaConteo3 { get; set; }
        public bool UnidadesProductoListaPredeterminado { get; set; }
    }
}
