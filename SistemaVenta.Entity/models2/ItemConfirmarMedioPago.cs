using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemConfirmarMedioPago
    {
        public int Pkid { get; set; }
        public int IdmedioDePago { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
