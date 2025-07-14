using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class AlmapoCosto
    {
        public string Codigo { get; set; } = null!;
        public string Producto { get; set; } = null!;
        public decimal Costo { get; set; }
        public string Unidad { get; set; } = null!;
        public int Factor { get; set; }
    }
}
