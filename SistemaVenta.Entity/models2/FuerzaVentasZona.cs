using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class FuerzaVentasZona
    {
        public int Pkid { get; set; }
        public int Idzona { get; set; }
        public int IdfuerzaVentas { get; set; }

        public virtual FuerzaVenta IdfuerzaVentasNavigation { get; set; } = null!;
        public virtual Zona IdzonaNavigation { get; set; } = null!;
    }
}
