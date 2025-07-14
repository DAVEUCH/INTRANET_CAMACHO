using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class SucursalBonificacion
    {
        public int Pkid { get; set; }
        public int Idbonificacion { get; set; }
        public int Idsucursal { get; set; }

        public virtual Bonificacion IdbonificacionNavigation { get; set; } = null!;
        public virtual Sucursal IdsucursalNavigation { get; set; } = null!;
    }
}
