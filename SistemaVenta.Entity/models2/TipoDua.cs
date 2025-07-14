using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoDua
    {
        public int Pkid { get; set; }
        public int IdimpuestoDua { get; set; }

        public virtual Impuesto IdimpuestoDuaNavigation { get; set; } = null!;
        public virtual TipoCp Pk { get; set; } = null!;
    }
}
