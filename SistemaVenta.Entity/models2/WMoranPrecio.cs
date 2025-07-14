using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class WMoranPrecio
    {
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
        public decimal? Mi { get; set; }
        public decimal? Ma { get; set; }
        public decimal? _07 { get; set; }
        public decimal? _05 { get; set; }
        public decimal? Gs { get; set; }
        public decimal? R2 { get; set; }
        public decimal? R3 { get; set; }
        public decimal? Ss { get; set; }
        public string Linea { get; set; } = null!;
        public string Lista { get; set; } = null!;
        public string Unidad { get; set; } = null!;
        public int Factor { get; set; }
        public string CodProv { get; set; } = null!;
        public string NomProv { get; set; } = null!;
    }
}
