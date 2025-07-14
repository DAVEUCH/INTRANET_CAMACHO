using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class NumCpContablePeriodo
    {
        public int Pkid { get; set; }
        public int Idperiodo { get; set; }
        public int IdnumCpContable { get; set; }
        public int Numero { get; set; }

        public virtual NumCpContable IdnumCpContableNavigation { get; set; } = null!;
        public virtual Periodo IdperiodoNavigation { get; set; } = null!;
    }
}
