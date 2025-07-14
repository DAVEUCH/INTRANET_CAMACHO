using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemPercepcion
    {
        public int Pkid { get; set; }
        public decimal MontoPercepcion { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
