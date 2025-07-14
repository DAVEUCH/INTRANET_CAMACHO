using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EOrdenamiento
    {
        public string OrdenamientosId { get; set; } = null!;
        public string Idreporte { get; set; } = null!;
        public string OrdenamientosNombre { get; set; } = null!;
        public int OrdenamientosPosicion { get; set; }
    }
}
