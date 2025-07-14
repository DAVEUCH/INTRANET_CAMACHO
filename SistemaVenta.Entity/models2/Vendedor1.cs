using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Vendedor1
    {
        public int Pkid { get; set; }

        public virtual Vendedor Pk { get; set; } = null!;
    }
}
