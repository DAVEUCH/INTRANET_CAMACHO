using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class CpDescuentoRecargo
    {
        public CpDescuentoRecargo()
        {
            ItemCpDescuentoRecargos = new HashSet<ItemCpDescuentoRecargo>();
        }

        public int Pkid { get; set; }
        public int Idcp { get; set; }
        public int IdtipoDescuentoRecargo { get; set; }
        public string Criterio { get; set; } = null!;
        public decimal Monto { get; set; }

        public virtual Cp IdcpNavigation { get; set; } = null!;
        public virtual TipoDescuentoRecargo IdtipoDescuentoRecargoNavigation { get; set; } = null!;
        public virtual ICollection<ItemCpDescuentoRecargo> ItemCpDescuentoRecargos { get; set; }
    }
}
