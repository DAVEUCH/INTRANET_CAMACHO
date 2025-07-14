using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemSolicitudCotizacion3
    {
        public int Pkid { get; set; }
        public bool Activo { get; set; }
        public decimal? BalanceFacturacion { get; set; }

        public virtual ItemCp Pk { get; set; } = null!;
    }
}
