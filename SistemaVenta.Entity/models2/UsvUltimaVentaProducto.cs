using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvUltimaVentaProducto
    {
        public int Idproducto { get; set; }
        public DateTime? UltimaFecha { get; set; }
        public int? ItemCppkid { get; set; }
    }
}
