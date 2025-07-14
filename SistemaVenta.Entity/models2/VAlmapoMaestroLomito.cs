using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmapoMaestroLomito
    {
        public int TipoCaracteristicaId { get; set; }
        public string LomitoCodigo { get; set; } = null!;
        public string LomitoNombre { get; set; } = null!;
        public int ProductoId { get; set; }
    }
}
