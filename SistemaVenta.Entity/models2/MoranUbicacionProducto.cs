using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class MoranUbicacionProducto
    {
        public int Pkid { get; set; }
        public int IdAmbienteAlmacen { get; set; }
        public int IdProducto { get; set; }
        public int Orden { get; set; }

        public virtual MoranAmbienteAlmacen IdAmbienteAlmacenNavigation { get; set; } = null!;
    }
}
