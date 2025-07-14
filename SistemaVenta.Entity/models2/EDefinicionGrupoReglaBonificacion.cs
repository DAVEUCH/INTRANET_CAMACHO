using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDefinicionGrupoReglaBonificacion
    {
        public int GruposReglaId { get; set; }
        public string GruposReglaEnlace { get; set; } = null!;
        public int IddefinicionBonificacion { get; set; }
    }
}
