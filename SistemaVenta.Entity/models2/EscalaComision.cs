using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EscalaComision
    {
        public int Pkid { get; set; }
        public decimal Desde { get; set; }
        public decimal Hasta { get; set; }
        public decimal Comision { get; set; }
        public int IdNivelVendedor { get; set; }
        public int IdComision { get; set; }
        public int IdCabComisionCuota { get; set; }

        public virtual CabComisionCuotum IdCabComisionCuotaNavigation { get; set; } = null!;
        public virtual Comision IdComisionNavigation { get; set; } = null!;
        public virtual NivelVendedor IdNivelVendedorNavigation { get; set; } = null!;
    }
}
