using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EDerechoOperacion
    {
        public int Idrol { get; set; }
        public int DerechosOperacionId { get; set; }
        public string DerechosOperacionNombreOperacion { get; set; } = null!;
    }
}
