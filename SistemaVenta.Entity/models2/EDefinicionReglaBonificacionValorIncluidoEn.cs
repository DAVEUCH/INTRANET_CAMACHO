using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDefinicionReglaBonificacionValorIncluidoEn
    {
        public int ValoresIncluidoEnId { get; set; }
        public int? ValoresIncluidoEnIdobjetoDatos { get; set; }
        public int? IddefinicionReglaBonificacion { get; set; }
        public string? ValoresIncluidoEnIdtipoAsociado { get; set; }
        public string ValoresIncluidoEnDescripcion { get; set; } = null!;
        public int? ValoresIncluidoEnClave { get; set; }
    }
}
