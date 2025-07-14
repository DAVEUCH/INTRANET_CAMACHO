using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvProductoSinImagene
    {
        public string CodigoProducto { get; set; } = null!;
        public string Oem { get; set; } = null!;
        public string LineaPadre { get; set; } = null!;
        public string LineaProducto { get; set; } = null!;
        public string MarcaProducto { get; set; } = null!;
        public string? AplicaProducto { get; set; }
        public int? Stock { get; set; }
    }
}
