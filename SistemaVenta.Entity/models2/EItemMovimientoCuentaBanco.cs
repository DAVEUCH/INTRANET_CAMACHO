using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemMovimientoCuentaBanco
    {
        public string ItemsDescripcion { get; set; } = null!;
        public string ItemsOficina { get; set; } = null!;
        public string ItemsNumeroOperacion { get; set; } = null!;
        public string ItemsFechaOperacion { get; set; } = null!;
        public string ItemsFechaValor { get; set; } = null!;
        public int IdmovimientoCuentaBanco { get; set; }
        public string? ItemsMonto { get; set; }
        public int ItemsId { get; set; }
        public int? ItemsCargoAbono { get; set; }
    }
}
