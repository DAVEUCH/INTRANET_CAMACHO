using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemCpDescuentoRecargo
    {
        public int ItemCpProrrateosId { get; set; }
        public int ItemCpProrrateosIditemCp { get; set; }
        public int IddescuentoRecargo { get; set; }
        public decimal ItemCpProrrateosMonto { get; set; }
    }
}
