using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpDistribucion
    {
        public int Pkid { get; set; }
        public int IdfuerzaVentas { get; set; }
        public int IdzonaVenta { get; set; }
        public int IdzonaReparto { get; set; }
        public bool FueraDeRuta { get; set; }
        public int IdgrupoVentas { get; set; }

        public virtual FuerzaVenta IdfuerzaVentasNavigation { get; set; } = null!;
        public virtual GrupoVenta IdgrupoVentasNavigation { get; set; } = null!;
        public virtual Zona IdzonaRepartoNavigation { get; set; } = null!;
        public virtual Zona IdzonaVentaNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
    }
}
