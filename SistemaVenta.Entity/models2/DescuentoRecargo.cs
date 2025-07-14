using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DescuentoRecargo
    {
        public int IdlistaPrecios { get; set; }
        public decimal Porcentaje { get; set; }
        public string DescuentoRecargo1 { get; set; } = null!;
        public int IdtipoMedioDePago { get; set; }
    }
}
