using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemCpActivoFijo
    {
        public int Pkid { get; set; }
        public int IdactivoFijo { get; set; }

        public virtual ActivoFijoActivoFijo IdactivoFijoNavigation { get; set; } = null!;
        public virtual ItemCpInventario Pk { get; set; } = null!;
    }
}
