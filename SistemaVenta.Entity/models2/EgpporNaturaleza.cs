using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EgpporNaturaleza
    {
        public int Pkid { get; set; }
        public int Idnivel { get; set; }
        public int IdnivelPadre { get; set; }
        public string Descripcion { get; set; } = null!;
        public int Orden { get; set; }
    }
}
