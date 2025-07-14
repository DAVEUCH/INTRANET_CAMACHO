using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvGcCategoriaVende
    {
        public int? Idvendedor { get; set; }
        public string? ChCodCatVende { get; set; }
        public string? VcDesCatVende { get; set; }
        public string Vendedor { get; set; } = null!;
    }
}
