using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VItemCpInventario
    {
        public string Idcp { get; set; } = null!;
        public int Idproducto { get; set; }
        public decimal? Cantidad { get; set; }
    }
}
