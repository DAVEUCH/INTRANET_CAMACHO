using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvProductoListaPrecio0
    {
        public int Idproducto { get; set; }
        public string CodigoProducto { get; set; } = null!;
        public string? Oem { get; set; }
        public string? UnidMed { get; set; }
        public int? Factor { get; set; }
        public int IdclaseProductoServicio { get; set; }
        public decimal? PrecioIncImptoSoles { get; set; }
    }
}
