using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class MalmapoRutas1
    {
        public string? Codvendedor { get; set; }
        public string? Zonaventa { get; set; }
        public int? RutaDia { get; set; }
        public int Frecuencia { get; set; }
        public string Fecha { get; set; } = null!;
    }
}
