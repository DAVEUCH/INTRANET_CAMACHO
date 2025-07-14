using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TabInventarioProductosAñoyMesMarcaResumen02
    {
        public double? Año { get; set; }
        public double? Mes { get; set; }
        public string? MarcaNombre { get; set; }
        public string SegRfm { get; set; } = null!;
        public double? CostoSegRfm { get; set; }
        public decimal? TotalCostoMarca { get; set; }
    }
}
