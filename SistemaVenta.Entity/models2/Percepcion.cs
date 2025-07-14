using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class Percepcion
    {
        public Percepcion()
        {
            ItemPercepcionConsolidadoCargas = new HashSet<ItemPercepcionConsolidadoCarga>();
        }

        public int Pkid { get; set; }
        public int IdcpCaja { get; set; }

        public virtual Cp Pk { get; set; } = null!;
        public virtual ICollection<ItemPercepcionConsolidadoCarga> ItemPercepcionConsolidadoCargas { get; set; }
    }
}
