using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvItemListaPrecio
    {
        public int Pkid { get; set; }
        public int IdlistaPrecios { get; set; }
        public int Idproducto { get; set; }
        public string? CodProducto { get; set; }
    }
}
