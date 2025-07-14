using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemJerarquiaDescuento
    {
        public int Pkid { get; set; }
        public int IdjerarquiaDescuento { get; set; }
        public int Iddescuento { get; set; }
        public int Jerarquia { get; set; }

        public virtual JerarquiaDescuento IdjerarquiaDescuentoNavigation { get; set; } = null!;
    }
}
