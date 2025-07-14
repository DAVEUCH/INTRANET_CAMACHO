using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class UnidadCodigoBarra
    {
        public int Pkid { get; set; }
        public int Idunidad { get; set; }
        public string Codigo { get; set; } = null!;

        public virtual Unidad IdunidadNavigation { get; set; } = null!;
    }
}
