using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoCotizacion
    {
        public int Pkid { get; set; }
        public int Idalmacen { get; set; }
        public bool RequiereCliente { get; set; }
        public bool RestringirAlmacen { get; set; }

        public virtual TipoCp Pk { get; set; } = null!;
    }
}
