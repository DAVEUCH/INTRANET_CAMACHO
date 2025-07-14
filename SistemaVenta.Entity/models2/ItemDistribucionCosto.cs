using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ItemDistribucionCosto
    {
        public int Pkid { get; set; }
        public int IddistribucionCostosCuentasContables { get; set; }
        public int IddistribucionCostosProductos { get; set; }
        public int IddistribucionCosto { get; set; }
        public decimal? Porcentaje { get; set; }
        public string? Posicion { get; set; }

        public virtual DistribucionCosto IddistribucionCostoNavigation { get; set; } = null!;
    }
}
