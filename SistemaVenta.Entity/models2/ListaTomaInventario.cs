using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ListaTomaInventario
    {
        public int Pkid { get; set; }
        public int IdtomaInventario { get; set; }
        public int IdlistaInventario { get; set; }

        public virtual ListaInventario IdlistaInventarioNavigation { get; set; } = null!;
        public virtual TomaInventario IdtomaInventarioNavigation { get; set; } = null!;
    }
}
