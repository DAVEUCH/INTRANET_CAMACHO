using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class EItemJerarquiaBonificacione
    {
        public int BonificacionesPkid { get; set; }
        public int IdjerarquiaBonificaciones { get; set; }
        public int BonificacionesIdbonificacion { get; set; }
        public int BonificacionesJerarquia { get; set; }
    }
}
