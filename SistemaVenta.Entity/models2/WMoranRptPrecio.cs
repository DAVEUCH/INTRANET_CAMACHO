using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class WMoranRptPrecio
    {
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public string Unidad { get; set; } = null!;
        public int Factor { get; set; }
        public decimal? Minorista { get; set; }
        public decimal? Mayorista { get; set; }
        public decimal? Siete { get; set; }
        public decimal? Cinco { get; set; }
        public decimal? Gs { get; set; }
        public decimal? Rdos { get; set; }
        public decimal? Rtres { get; set; }
        public decimal? Ss { get; set; }
        public string? CodProv { get; set; }
        public string? NomProv { get; set; }
        public string? Linea { get; set; }
    }
}
