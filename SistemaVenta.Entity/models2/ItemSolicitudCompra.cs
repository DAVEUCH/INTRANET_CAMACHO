using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemSolicitudCompra
    {
        public ItemSolicitudCompra()
        {
            ProveedorItemSolicitudCompras = new HashSet<ProveedorItemSolicitudCompra>();
        }

        public int Pkid { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
        public virtual ICollection<ProveedorItemSolicitudCompra> ProveedorItemSolicitudCompras { get; set; }
    }
}
