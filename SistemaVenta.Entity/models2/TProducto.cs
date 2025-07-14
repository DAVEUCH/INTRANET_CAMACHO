using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TProducto
    {
        public int? ProductoId { get; set; }
        public string? ProductoCodigo { get; set; }
        public string? ProductoDescripcion { get; set; }
        public int? ClaseProductoId { get; set; }
    }
}
