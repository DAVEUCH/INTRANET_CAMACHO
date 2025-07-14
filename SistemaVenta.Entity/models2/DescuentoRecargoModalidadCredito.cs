using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class DescuentoRecargoModalidadCredito
    {
        public int Pkid { get; set; }
        public int IdlistaPrecios { get; set; }
        public string DescuentoRecargo { get; set; } = null!;
        public int IdmodalidadCredito { get; set; }
        public decimal Porcentaje { get; set; }
    }
}
