using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabProdStockInsuficiente
    {
        public string? Codigo { get; set; }
        public int? Stock { get; set; }
        public int? Canti { get; set; }
    }
}
