using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Idtabla
    {
        public string Tabla { get; set; } = null!;
        public int Id { get; set; }
        public byte[] UltimaModificacion { get; set; } = null!;
    }
}
