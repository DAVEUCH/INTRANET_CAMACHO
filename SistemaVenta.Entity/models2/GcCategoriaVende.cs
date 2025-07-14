using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class GcCategoriaVende
    {
        public string? ChCodCatVende { get; set; }
        public string? VcDesCatVende { get; set; }
        public decimal? DeCuotaCatVende { get; set; }
        public decimal? DeCuotaCatVendeMax { get; set; }
        public decimal? DeCuotaCatVendeMin { get; set; }
    }
}
