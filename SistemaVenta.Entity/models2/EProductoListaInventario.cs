using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EProductoListaInventario
    {
        public int ProductosListaId { get; set; }
        public int IdlistaInventario { get; set; }
        public int ProductosListaIdproducto { get; set; }
        public int Id { get; set; }
    }
}
