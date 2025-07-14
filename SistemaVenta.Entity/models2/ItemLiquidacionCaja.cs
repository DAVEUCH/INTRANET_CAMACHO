using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemLiquidacionCaja
    {
        public int IdliquidacionCaja { get; set; }
        public int Idcp { get; set; }

        public virtual Cp IdcpNavigation { get; set; } = null!;
        public virtual LiquidacionCaja IdliquidacionCajaNavigation { get; set; } = null!;
    }
}
