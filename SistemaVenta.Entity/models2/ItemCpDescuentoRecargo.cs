using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCpDescuentoRecargo
    {
        public int Pkid { get; set; }
        public int IddescuentoRecargo { get; set; }
        public int IditemCp { get; set; }
        public decimal Monto { get; set; }

        public virtual CpDescuentoRecargo IddescuentoRecargoNavigation { get; set; } = null!;
        public virtual ItemPoliticaVentaDescuentoRecargo ItemPoliticaVentaDescuentoRecargo { get; set; } = null!;
    }
}
