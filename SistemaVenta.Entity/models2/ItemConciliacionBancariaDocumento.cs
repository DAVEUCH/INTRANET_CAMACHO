using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemConciliacionBancariaDocumento
    {
        public int Pkid { get; set; }
        public int IdconciliacionBancaria { get; set; }
        public int Idcp { get; set; }
        public string IdtipoCp { get; set; } = null!;
        public int IditemConciliacionBancaria { get; set; }

        public virtual ConciliacionBancarium IdconciliacionBancariaNavigation { get; set; } = null!;
        public virtual Cp IdcpNavigation { get; set; } = null!;
    }
}
