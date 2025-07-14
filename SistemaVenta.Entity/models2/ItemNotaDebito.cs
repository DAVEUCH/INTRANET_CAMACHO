using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemNotaDebito
    {
        public int Pkid { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
