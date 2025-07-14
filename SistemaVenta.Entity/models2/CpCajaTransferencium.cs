using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpCajaTransferencium
    {
        public int Pkid { get; set; }
        public decimal TotalSoles { get; set; }
        public decimal TotalDolares { get; set; }

        public virtual Cp Pk { get; set; } = null!;
    }
}
