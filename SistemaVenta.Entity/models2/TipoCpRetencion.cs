using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class TipoCpRetencion
    {
        public int Pkid { get; set; }
        public decimal Porcentaje { get; set; }
        public decimal MontoMinimo { get; set; }
        public bool TieneMontoMinimo { get; set; }

        public virtual TipoCp Pk { get; set; } = null!;
    }
}
