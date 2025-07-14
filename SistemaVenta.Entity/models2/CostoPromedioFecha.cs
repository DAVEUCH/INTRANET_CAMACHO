using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CostoPromedioFecha
    {
        public DateTime Fecha { get; set; }
        public int Idproducto { get; set; }
        public decimal CostoPromedioSoles { get; set; }
        public decimal CostoPromedioDolares { get; set; }
    }
}
