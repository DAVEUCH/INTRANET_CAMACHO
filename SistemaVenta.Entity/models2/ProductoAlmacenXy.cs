using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductoAlmacenXy
    {
        public DateTime? Fecha { get; set; }
        public int? Idalmacen { get; set; }
        public int? Idproducto { get; set; }
        public int? Anterior { get; set; }
        public int? Entrada { get; set; }
        public int? Salida { get; set; }
        public int? Saldo { get; set; }
    }
}
