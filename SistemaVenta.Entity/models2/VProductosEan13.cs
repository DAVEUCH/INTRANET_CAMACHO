using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VProductosEan13
    {
        public int Pkidproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public int Factor { get; set; }
        public string Ean13 { get; set; } = null!;
    }
}
