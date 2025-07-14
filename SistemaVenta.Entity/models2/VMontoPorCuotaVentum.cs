using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMontoPorCuotaVentum
    {
        public int Idcuota { get; set; }
        public int Idagrupacion { get; set; }
        public int Idvendedor { get; set; }
        public decimal? Monto { get; set; }
        public string Vendedor { get; set; } = null!;
        public string Agrupacion { get; set; } = null!;
        public DateTime Fecha { get; set; }
    }
}
