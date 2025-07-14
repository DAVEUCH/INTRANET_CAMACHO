using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoCpCompra
    {
        public int Pkid { get; set; }
        public int Idalmacen { get; set; }
        public bool RestringirAlmacen { get; set; }
        public bool Importacion { get; set; }

        public virtual TipoCp Pk { get; set; } = null!;
    }
}
