using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class BiClientesAñosymese
    {
        public int? ClienteId { get; set; }
        public string? ClienteNombre { get; set; }
        public string? ClienteRuc { get; set; }
        public string? Año { get; set; }
        public string? Mes { get; set; }
        public decimal? Total { get; set; }
    }
}
