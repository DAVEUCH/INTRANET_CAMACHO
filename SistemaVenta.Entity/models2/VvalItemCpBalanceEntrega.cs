using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VvalItemCpBalanceEntrega
    {
        public int CpOrigenId { get; set; }
        public int CpOrigenItemId { get; set; }
        public decimal? CantidadMonto { get; set; }
    }
}
