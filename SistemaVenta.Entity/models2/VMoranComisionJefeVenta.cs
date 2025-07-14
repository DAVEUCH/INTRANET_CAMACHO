using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranComisionJefeVenta
    {
        public int Pkid { get; set; }
        public string Mes { get; set; } = null!;
        public decimal Año { get; set; }
        public string? Descripcion { get; set; }
        public int Idsucursal { get; set; }
        public int IdcuotaVenta { get; set; }
        public string Nivel { get; set; } = null!;
    }
}
