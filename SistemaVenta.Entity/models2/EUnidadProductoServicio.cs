using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EUnidadProductoServicio
    {
        public int IdproductoServicio { get; set; }
        public int UnidadesIdunidad { get; set; }
        public bool UnidadesUnidadReferencia { get; set; }
    }
}
