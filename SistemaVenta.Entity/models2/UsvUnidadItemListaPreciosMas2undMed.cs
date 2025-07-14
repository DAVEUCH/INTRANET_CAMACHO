using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsvUnidadItemListaPreciosMas2undMed
    {
        public int IdlistaPrecios { get; set; }
        public int IditemListaPrecios { get; set; }
        public int Idproducto { get; set; }
        public int? CantProductos { get; set; }
    }
}
