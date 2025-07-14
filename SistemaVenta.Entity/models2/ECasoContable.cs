using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ECasoContable
    {
        public int CasosContablesId { get; set; }
        public int IdasientoTipo { get; set; }
        public string CasosContablesGlosa { get; set; } = null!;
    }
}
