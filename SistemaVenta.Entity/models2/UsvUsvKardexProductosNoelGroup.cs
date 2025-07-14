using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvUsvKardexProductosNoelGroup
    {
        public int Idsucursal { get; set; }
        public string SucursalNombre { get; set; } = null!;
        public int? Año { get; set; }
        public int? Mes { get; set; }
        public int Idproducto { get; set; }
        public string ProductoCodigo { get; set; } = null!;
        public string ProductoDescripcion { get; set; } = null!;
        public int? Stock { get; set; }
        public decimal? Costoprom { get; set; }
    }
}
