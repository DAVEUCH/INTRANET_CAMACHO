using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDefinicionReglaDescuentoValorIncluidoEn
    {
        public int ValoresIncluidoEnId { get; set; }
        public int? ValoresIncluidoEnIdobjetoDatos { get; set; }
        public string? ValoresIncluidoEnIdtipoAsociado { get; set; }
        public int? IddefinicionReglaDescuento2 { get; set; }
        public string ValoresIncluidoEnDescripcion { get; set; } = null!;
        public int? ValoresIncluidoEnClave { get; set; }
    }
}
