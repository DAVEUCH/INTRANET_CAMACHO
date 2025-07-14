using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAsientoPasosCondicion
    {
        public int IdcargoAbonoTipo { get; set; }
        public string Condicion { get; set; } = null!;
        public int Idproceso { get; set; }
    }
}
