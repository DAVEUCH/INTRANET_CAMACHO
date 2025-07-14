using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GcCateVendeComiPorMarca
    {
        public string? ChCodCatVende { get; set; }
        public int? Idmarca { get; set; }
        public string? CodMarca { get; set; }
        public decimal? PorcenRango { get; set; }
        public decimal? PorcenComi { get; set; }
        public decimal? PorcenComiCp { get; set; }
    }
}
