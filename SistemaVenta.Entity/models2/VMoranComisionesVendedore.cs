using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranComisionesVendedore
    {
        public int Idvendedor { get; set; }
        public int Idnivel { get; set; }
        public int Idsucursal { get; set; }
        public int Idcomision { get; set; }
        public int IdcuotaVenta { get; set; }
        public int IdCabComisionCuota { get; set; }
        public int? IdTipoNivel { get; set; }
    }
}
