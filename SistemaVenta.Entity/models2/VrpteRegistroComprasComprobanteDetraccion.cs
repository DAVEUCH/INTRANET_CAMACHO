using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VrpteRegistroComprasComprobanteDetraccion
    {
        public int Idcp { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime FechaEmision { get; set; }
        public string NumCp { get; set; } = null!;
    }
}
