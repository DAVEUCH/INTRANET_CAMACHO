using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GrupoVentasItemListaPrecio
    {
        public int Pkid { get; set; }
        public int IdgrupoVentas { get; set; }
        public int IditemListaPrecios { get; set; }

        public virtual GrupoVenta IdgrupoVentasNavigation { get; set; } = null!;
    }
}
