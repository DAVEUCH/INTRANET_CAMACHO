using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpRetencion
    {
        public int Pkid { get; set; }
        public decimal PorcentajeRetencion { get; set; }
        public decimal MontoMinimo { get; set; }

        public virtual Cp Pk { get; set; } = null!;
    }
}
