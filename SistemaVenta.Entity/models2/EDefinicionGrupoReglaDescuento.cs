using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDefinicionGrupoReglaDescuento
    {
        public string GruposReglaEnlace { get; set; } = null!;
        public int GruposReglaId { get; set; }
        public int IddefinicionDescuento2 { get; set; }
    }
}
