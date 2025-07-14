using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranComisionesJefeVenta
    {
        public int IdjefeVentas { get; set; }
        public int Idgerente { get; set; }
        public int Idnivel { get; set; }
        public int? IdComision { get; set; }
    }
}
