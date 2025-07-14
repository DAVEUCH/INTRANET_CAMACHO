using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvCompComprayEntraAlmaRelacion
    {
        public int PkidCompCompra { get; set; }
        public string NumeroCompCompra { get; set; } = null!;
        public string TipoDocIngresoMercaderia { get; set; } = null!;
        public string NumeroIngresoMercaderia { get; set; } = null!;
        public DateTime FechaIngresoMercaderia { get; set; }
    }
}
