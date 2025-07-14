using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class SucursalListaPrecio
    {
        public int Idsucursal { get; set; }
        public int IdlistaPrecios { get; set; }

        public virtual ListaPrecio IdlistaPreciosNavigation { get; set; } = null!;
        public virtual Sucursal IdsucursalNavigation { get; set; } = null!;
    }
}
