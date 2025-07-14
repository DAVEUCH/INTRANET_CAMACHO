using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoSolicitudCompra
    {
        public int Pkid { get; set; }
        public int Idalmacen { get; set; }
        public bool RequiereAprobacion { get; set; }

        public virtual TipoCp Pk { get; set; } = null!;
    }
}
