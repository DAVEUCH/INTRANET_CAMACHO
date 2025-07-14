using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemPoliticaVentaDescuentoRecargo
    {
        public int Pkid { get; set; }
        public bool? Sucesivo { get; set; }
        public decimal? PorcentajeDescuentoDefinicion { get; set; }
        public decimal? PorcentajeDescuentoAplicado { get; set; }
        public int? IddefinicionDescuento { get; set; }

        public virtual ItemCpDescuentoRecargo Pk { get; set; } = null!;
    }
}
