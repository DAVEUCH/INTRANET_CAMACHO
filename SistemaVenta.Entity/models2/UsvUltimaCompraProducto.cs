using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvUltimaCompraProducto
    {
        public int Idproducto { get; set; }
        public DateTime? UltimaFecha { get; set; }
        public int? ItemCppkid { get; set; }
    }
}
