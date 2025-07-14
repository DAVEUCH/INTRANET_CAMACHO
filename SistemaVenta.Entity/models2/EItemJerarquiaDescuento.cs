using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemJerarquiaDescuento
    {
        public int DescuentosPkid { get; set; }
        public int IdjerarquiaDescuento { get; set; }
        public int DescuentosIddescuento { get; set; }
        public int DescuentosJerarquia { get; set; }
    }
}
