using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ActivoFijoUbicacionActivoFijo
    {
        public int Pkid { get; set; }
        public int Idresponsable { get; set; }

        public virtual Empleado IdresponsableNavigation { get; set; } = null!;
        public virtual Almacen Pk { get; set; } = null!;
    }
}
