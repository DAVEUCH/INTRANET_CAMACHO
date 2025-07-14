using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProductoFreddy
    {
        public int Pkid { get; set; }
        public string? CodigoInterno { get; set; }
        public string? ProductoAlias { get; set; }

        public virtual Producto Pk { get; set; } = null!;
    }
}
