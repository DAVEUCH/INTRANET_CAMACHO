using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductosVentasAñoMe
    {
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int? Idproducto { get; set; }
        public int? Idalmacen { get; set; }
        public decimal? CantVentasUnidades { get; set; }
    }
}
