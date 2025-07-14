using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VProductosDum14
    {
        public int Pkidproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public int Factor { get; set; }
        public string Dum14 { get; set; } = null!;
    }
}
