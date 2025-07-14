using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class JerarquiaBonificacione
    {
        public JerarquiaBonificacione()
        {
            ItemJerarquiaBonificaciones = new HashSet<ItemJerarquiaBonificacione>();
        }

        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string Descripcion { get; set; } = null!;

        public virtual ICollection<ItemJerarquiaBonificacione> ItemJerarquiaBonificaciones { get; set; }
    }
}
