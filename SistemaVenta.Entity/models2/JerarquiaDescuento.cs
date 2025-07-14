using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class JerarquiaDescuento
    {
        public JerarquiaDescuento()
        {
            ItemJerarquiaDescuentos = new HashSet<ItemJerarquiaDescuento>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<ItemJerarquiaDescuento> ItemJerarquiaDescuentos { get; set; }
    }
}
