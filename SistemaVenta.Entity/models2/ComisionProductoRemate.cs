using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ComisionProductoRemate
    {
        public int? Idproducto { get; set; }
        public int? IdlistaPrecio { get; set; }
        public decimal? PorcenDscto { get; set; }
    }
}
