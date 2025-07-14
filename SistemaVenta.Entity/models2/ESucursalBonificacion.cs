using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class ESucursalBonificacion
    {
        public int SucursalesId { get; set; }
        public int Idbonificacion { get; set; }
        public int SucursalesIdsucursal { get; set; }
    }
}
