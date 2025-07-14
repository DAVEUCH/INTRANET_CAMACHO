using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class RptArticulosSinMov
    {
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoNombre { get; set; } = null!;
        public string AlmacenCodigo { get; set; } = null!;
        public string AlmacenNombre { get; set; } = null!;
        public string AlmacenTransito { get; set; } = null!;
        public int? AlmacenStock { get; set; }
        public decimal? DiasSinMov { get; set; }
        public int ClaseId { get; set; }
        public string ClaseNombre { get; set; } = null!;
        public int ClasePadreId { get; set; }
        public string ClasePadreNombre { get; set; } = null!;
        public string Unidad { get; set; } = null!;
    }
}
