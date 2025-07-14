using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvTabInventarioProductosAñoyMesRfmScoreMax
    {
        public double? Idproducto { get; set; }
        public string? Codigo { get; set; }
        public double? PuntuaciónActualidad { get; set; }
        public double? PuntuaciónFrecuencia { get; set; }
        public double? PuntuaciónMonetaria { get; set; }
        public double? PuntuaciónRfm { get; set; }
        public double? ScoreRfm { get; set; }
        public string SegRfm { get; set; } = null!;
        public int? CantClie { get; set; }
    }
}
