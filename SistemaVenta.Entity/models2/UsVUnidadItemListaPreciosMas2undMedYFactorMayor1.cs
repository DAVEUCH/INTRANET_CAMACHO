using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UsVUnidadItemListaPreciosMas2undMedYFactorMayor1
    {
        public int ItemListaPreciosId { get; set; }
        public int IdlistaPrecios { get; set; }
        public int Idproducto { get; set; }
        public string Codigo { get; set; } = null!;
        public int UnidadItemListaPreciosId { get; set; }
        public int Idunidad { get; set; }
        public int Factor { get; set; }
    }
}
