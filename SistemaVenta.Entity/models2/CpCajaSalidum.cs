using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpCajaSalidum
    {
        public int Pkid { get; set; }
        public int Idcaja { get; set; }
        public bool PagoDetraccion { get; set; }
        public decimal TotalSoles { get; set; }
        public decimal TotalDolares { get; set; }
        public bool PercepcionAplicada { get; set; }

        public virtual Caja IdcajaNavigation { get; set; } = null!;
        public virtual Cp Pk { get; set; } = null!;
    }
}
