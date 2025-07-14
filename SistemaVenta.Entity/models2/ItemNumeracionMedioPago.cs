using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemNumeracionMedioPago
    {
        public int Pkid { get; set; }
        public int? IdtipoMedioDePago { get; set; }
        public int? IdnumeracionMedioPago { get; set; }

        public virtual NumeracionMedioPago? IdnumeracionMedioPagoNavigation { get; set; }
    }
}
