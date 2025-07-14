using System;
using System.Collections.Generic;

namespace SistemaVenta.Entity.models2
{
    public partial class VMoranLineasReducirNc
    {
        public int Pkid { get; set; }
        public string Codigo { get; set; } = null!;
        public string? CodMoran { get; set; }
        public decimal Monto { get; set; }
        public decimal? LineaPAct { get; set; }
        public decimal? LineaPNuev { get; set; }
        public decimal Saldo { get; set; }
        public decimal? Reduccion { get; set; }
        public string Linea { get; set; } = null!;
    }
}
