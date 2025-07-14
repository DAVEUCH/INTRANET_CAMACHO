using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemJerarquiaBonificacione
    {
        public int Pkid { get; set; }
        public int IdjerarquiaBonificaciones { get; set; }
        public int Idbonificacion { get; set; }
        public int Jerarquia { get; set; }

        public virtual Bonificacion IdbonificacionNavigation { get; set; } = null!;
        public virtual JerarquiaBonificacione IdjerarquiaBonificacionesNavigation { get; set; } = null!;
    }
}
