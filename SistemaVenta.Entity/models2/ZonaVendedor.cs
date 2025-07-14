using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ZonaVendedor
    {
        public int Pkid { get; set; }
        public int IdasignacionRutaZonaVendedor { get; set; }
        public int Idzona { get; set; }

        public virtual AsignacionRutaZonaVendedor IdasignacionRutaZonaVendedorNavigation { get; set; } = null!;
        public virtual Zona IdzonaNavigation { get; set; } = null!;
    }
}
