using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemFuerzaVentasVendedor
    {
        public int Pkid { get; set; }
        public int? Idvendedor { get; set; }
        public int? IdfuerzaVentas { get; set; }

        public virtual FuerzaVenta? IdfuerzaVentasNavigation { get; set; }
        public virtual Vendedor? IdvendedorNavigation { get; set; }
    }
}
