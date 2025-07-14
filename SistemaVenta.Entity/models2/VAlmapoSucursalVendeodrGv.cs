using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VAlmapoSucursalVendeodrGv
    {
        public int Idvendedor { get; set; }
        public int IdgrupoVentas { get; set; }
        public string Grupo { get; set; } = null!;
        public int Idsucursal { get; set; }
    }
}
