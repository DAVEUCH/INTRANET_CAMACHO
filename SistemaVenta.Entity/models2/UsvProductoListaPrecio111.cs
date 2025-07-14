using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvProductoListaPrecio111
    {
        public long? Item { get; set; }
        public string? MarPr { get; set; }
        public string CodigoProducto { get; set; } = null!;
        public string? Oem { get; set; }
        public string? LineaProducto { get; set; }
        public string? AplicaProducto { get; set; }
        public string? UnidMed { get; set; }
        public string? PrecioUnitario { get; set; }
        public int? Stock { get; set; }
        public int? StockFijo { get; set; }
        public int Idproducto { get; set; }
    }
}
