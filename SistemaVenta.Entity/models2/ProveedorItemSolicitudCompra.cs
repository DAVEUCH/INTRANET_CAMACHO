using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ProveedorItemSolicitudCompra
    {
        public int Pkid { get; set; }
        public int IditemSolicitudCompra { get; set; }
        public int Idproveedor { get; set; }

        public virtual ItemSolicitudCompra IditemSolicitudCompraNavigation { get; set; } = null!;
        public virtual Persona IdproveedorNavigation { get; set; } = null!;
    }
}
