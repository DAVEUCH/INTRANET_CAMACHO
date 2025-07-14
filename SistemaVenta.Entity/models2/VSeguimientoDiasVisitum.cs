using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VSeguimientoDiasVisitum
    {
        public string Codigo { get; set; } = null!;
        public string Nombre { get; set; } = null!;
        public string DiaDeSemana { get; set; } = null!;
        public string CodigoDia { get; set; } = null!;
        public int Pkid { get; set; }
    }
}
