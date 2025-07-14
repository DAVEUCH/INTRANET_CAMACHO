using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class AlmapoComision
    {
        public string Codigo { get; set; } = null!;
        public string Proveedor { get; set; } = null!;
        public string Categoria { get; set; } = null!;
        public int Credito { get; set; }
        public decimal Comision { get; set; }
        public int Dias { get; set; }
    }
}
