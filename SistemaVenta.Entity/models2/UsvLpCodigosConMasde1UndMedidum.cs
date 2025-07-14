using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvLpCodigosConMasde1UndMedidum
    {
        public int IdlistaPrecios { get; set; }
        public string Lpnombre { get; set; } = null!;
        public int IditemListaPrecios { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public int? CantUndMedidas { get; set; }
    }
}
