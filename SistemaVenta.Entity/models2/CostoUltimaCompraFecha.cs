using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CostoUltimaCompraFecha
    {
        public DateTime Fecha { get; set; }
        public int Idproducto { get; set; }
        public decimal CostoSoles { get; set; }
        public decimal CostoDolares { get; set; }
    }
}
